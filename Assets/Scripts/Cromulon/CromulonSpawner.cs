using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CromulonSpawner : MonoBehaviour {
    
	[SerializeField] private Transform[] spawnPoints;
	[SerializeField] private float spawnInterval = 2f;
    
	[SerializeField] private GameObject enemy;
    
	public void Construct(Transform[] points, float time, GameObject _gameObject){
		spawnPoints = points;
		spawnInterval = time;
		enemy = _gameObject;
	}

	public void Spawner()
    {
		//Choose a random spawn point from list of spawn points
        int randomSpawnIndex = Random.Range(0, spawnPoints.Length);
        //Create an instance of the Cromulon at the transform
        Instantiate(enemy, spawnPoints[randomSpawnIndex].position, spawnPoints[randomSpawnIndex].rotation);
    }

	// At initialization
	void Start () {
		//Starts Coroutine to spawn Cromulons in the given interval
		InvokeRepeating("Spawner", spawnInterval, spawnInterval);
	}
}
