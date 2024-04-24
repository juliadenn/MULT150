using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject BunnyPrefab;
    public Vector3 spawnRange;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= Random.Range(1,5); i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange.x, spawnRange.x), 1f,
                Random.Range(-spawnRange.z, spawnRange.z));
            Instantiate<GameObject>(BunnyPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
