using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleQ1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float forwardSpeed = 15f;
    public float rotationSpeed = 30f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * forwardSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * rotationSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
        }
    }
}
