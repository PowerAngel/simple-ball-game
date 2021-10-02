using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawner : MonoBehaviour
{
    public GameObject pointBlock;
    public float spawnTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        int spawnPointX = Random.Range(-24, 24);
        int spawnPointZ = Random.Range(-24, 24);

        Vector3 spawnPosition = new Vector3(spawnPointX, 0.5f, spawnPointZ);

        Instantiate(pointBlock, spawnPosition, Quaternion.identity);
    }
}
