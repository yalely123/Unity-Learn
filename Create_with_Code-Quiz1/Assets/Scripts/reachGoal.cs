using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reachGoal : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isShown = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 120 && !isShown)
        {
            Debug.Log("You win Keng mak kub jub jub");
            isShown = true;
        }
    }
}
