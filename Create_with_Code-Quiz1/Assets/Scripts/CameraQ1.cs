using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraQ1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 positionOffset = new Vector3(0, 2, 0);
    public GameObject player;

    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + positionOffset;
        transform.rotation = player.transform.rotation;
        
    }
}
