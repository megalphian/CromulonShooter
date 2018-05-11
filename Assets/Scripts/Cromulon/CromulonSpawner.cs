using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CromulonSpawner : MonoBehaviour {
    
	public Transform[] spawnPoints;
	public float spawnInterval = 4f;
    
	public GameObject enemy;
    

	public void Spawner()
    {
		//Choose a random spawn point from list of spawn points
        int randomSpawnIndex = Random.Range(0, spawnPoints.Length);
        //Create an instance of the Cromulon at the transform
        Instantiate(enemy, spawnPoints[randomSpawnIndex].position, spawnPoints[randomSpawnIndex].rotation);
    }

	// At initialization
	public void Start () {
		//Starts Coroutine to spawn Cromulons in the given interval
		InvokeRepeating("Spawner", spawnInterval, spawnInterval);
	}
}
