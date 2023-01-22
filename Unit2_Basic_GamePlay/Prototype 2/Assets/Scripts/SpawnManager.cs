using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    public float spawnRangeX = 15f;
    public float spawnPosZ = 35f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, 3);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(
            animalPrefab[animalIndex],
            spawnPos,
            animalPrefab[animalIndex].transform.rotation
        );
    }
}
