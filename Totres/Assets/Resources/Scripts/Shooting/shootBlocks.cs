using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootBlocks : MonoBehaviour {

    public GameObject Enemy;                // The enemy prefab to be spawned.

    public float spawnTime;          // How long between each spawn.
    //public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    //public Vector3 spawnPoint;
    private int spawnPointX = -8;
    private int spawnPointY = 3;


    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        spawnTime = Random.Range(2, 7);
    }




    void Spawn()
    {
        /* If the player has no health left...
        if (playerHealth.currentHealth <= 0f)
        {
            // ... exit the function.
            return;
        }*/

        // Find a random index between zero and one less than the number of spawn points.
        /*
        int whichPoint = Random.Range(0, 3);


        if (whichPoint == 0)
        {
            spawnPointX = -8;
            spawnPointY = 3;

        }

        if (whichPoint == 1)
        {
            //spawnPoint = new Vector3(0, 12, 0);
            spawnPointX = -8;
            spawnPointY = 8;
        }

        if (whichPoint == 2)
        {
            //spawnPoint = new Vector3(-12, 0, 0);
            spawnPointX = 28;
            spawnPointY = -2;
        }

        if (whichPoint == 3)
        {
            //spawnPoint = new Vector3(12, 0, 0);
            spawnPointX = 18;
            spawnPointY = -13;
        }*/
        Vector3 spawnPoint = new Vector3(spawnPointX, spawnPointY, 0);

    
        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(Enemy, spawnPoint, Quaternion.identity);
    }
}
