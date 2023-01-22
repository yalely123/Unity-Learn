using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizonalInput;
    public float speed = 15.0f;
    public float xRange = 15.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -15)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 15)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizonalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizonalInput * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
