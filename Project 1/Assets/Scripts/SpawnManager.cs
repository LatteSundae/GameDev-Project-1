using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefabs; 
    public float delayTimer = 1f;
    public float spawnRangeX = 5.4f; 
    public float spawnPosZ = 180; 
    float timer;
    int num;

    // Start is called before the first frame update
    void Start()    
    {
        timer = delayTimer;
    }

    // Update is called once per frame
        void Update()
        {
            num = Random.Range(1, 3);
            if(num == 1)
            {
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                Vector3 spawnPos = new Vector3(-spawnRangeX, 0, transform.position.z); 
                Instantiate(enemyPrefabs, spawnPos, enemyPrefabs.transform.rotation); 
                timer = delayTimer;
                }
            }

            else if(num == 2)
            {
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                Vector3 spawnPos = new Vector3(spawnRangeX, 0, transform.position.z); 
                Instantiate(enemyPrefabs, spawnPos, enemyPrefabs.transform.rotation); 
                timer = delayTimer;
                }
            }

        }
}
