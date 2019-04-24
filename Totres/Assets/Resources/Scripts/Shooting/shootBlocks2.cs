using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootBlocks2: MonoBehaviour {
    public GameObject Enemy;                // The enemy prefab to be spawned.
    public float spawnTime;          // How long between each spawn.
    private int spawnPointX = -8;
    private int spawnPointY = -8;


    // Use this for initialization
    void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        spawnTime = Random.Range(2, 7);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Spawn()
    {
        Vector3 spawnPoint = new Vector3(spawnPointX, spawnPointY, 0);

        Instantiate(Enemy, spawnPoint, Quaternion.identity);
    }
}
