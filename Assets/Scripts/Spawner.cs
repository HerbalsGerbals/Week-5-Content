using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public int spawnNumber = 5;
    public float spacing = 2.0f;
    public Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnNumber; i ++)
        {
            Vector3 spawnPosition = new Vector3(i * spacing, 0, 0);
            Vector3 position = new Transform(myTransform);
            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
