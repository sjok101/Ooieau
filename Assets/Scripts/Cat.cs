using Unity.VisualScripting;
using UnityEngine;

public class Cat : MonoBehaviour
{
    private Transform catTF;
    [SerializeField] private float rotationSpeed = 0.0f;
    [SerializeField] private float multiplier = 1.0f;
    private float yDegree = 0;
    private float timer = 0f;
    void Start()
    {
        catTF = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotationSpeed = rotationSpeed + 1*multiplier;
            timer = 1f;
            Debug.Log("Click");
        }
        timer -= Time.deltaTime;

        if (rotationSpeed > 0 && timer<=0)
        {
            rotationSpeed -= Time.deltaTime*rotationSpeed;
            Debug.Log(timer);
        }

        if (rotationSpeed < 1 && timer <= 0)
        {
            rotationSpeed = 0;
        }
        yDegree = (yDegree + Time.deltaTime*rotationSpeed)%360;
        catTF.localRotation = Quaternion.Euler(0, yDegree, 0); 
    }
}
