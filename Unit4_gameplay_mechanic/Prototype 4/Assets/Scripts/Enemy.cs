using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private Rigidbody enemyRb;
    public float speed = 3.0f;
    void Start()
    {
        player = GameObject.Find("Player");
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized; 
        // postion of player minus every axis by enemy position that mean direction which  point toward player
        enemyRb.AddForce(lookDirection * speed);
    }
}
