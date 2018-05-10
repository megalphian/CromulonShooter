using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CromulonSpawner : MonoBehaviour {
    
	public Transform[] spawnPoints;

	public float offsetFromCenter = 4f;
	public float spawnInterval = 4f;
    
	public GameObject enemy;

	//private void DefineSpawnPoints(Vector3 position){
		
	//}

	public void Spawner()
    {
        int randomSpawnIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[randomSpawnIndex].position, spawnPoints[randomSpawnIndex].rotation);
    }

	// Use this for initialization
	public void Start () {
		//DefineSpawnPoints(rootSpawnPoint.position);
		InvokeRepeating("Spawner", spawnInterval, spawnInterval);
	}
}
