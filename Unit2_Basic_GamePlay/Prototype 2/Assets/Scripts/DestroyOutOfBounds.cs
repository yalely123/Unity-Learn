using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound = 35.0f;
    private float buttomBound = -10f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // when animal pass player that's mean game over
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < buttomBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
