using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWalls : MonoBehaviour
{
    [SerializeField] float spawnInterval = 0.5f;//interval between when walls spawn in seconds

    [SerializeField] float spawnPositionZ = 20f;

    [SerializeField] GameObject wall_0;

    [SerializeField] GameObject wall_1;

    float prevSpawnTime;

    int whichWall = 0;

    // Start is called before the first frame update
    void Start()
    {
        prevSpawnTime = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - prevSpawnTime >= spawnInterval) {
            if (whichWall == 0) {
                whichWall = 1;
                Instantiate(wall_0, new Vector3(0, 0, spawnPositionZ), Quaternion.identity);
            }
            else {
                whichWall = 0;
                Instantiate(wall_1, new Vector3(0, 0, spawnPositionZ), Quaternion.identity);
            }
            prevSpawnTime = Time.time;
        }


    }
}
