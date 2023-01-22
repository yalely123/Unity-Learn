using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 30;
    private PlayerController playerControllerScript;
    private float leftBound = -10;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        // GameObject.Find("Player") is find Player in hierachy
        // and GetComponent is get component which is PlayerComtroller in "Player"
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver  == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        
    }
}
