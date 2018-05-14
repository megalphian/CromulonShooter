using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class SpawnerTest {
    
	List<Transform> spawn;

    [Test]
    public void SpawnerTestSimplePasses() {
        
    }
     
	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator SpawnerTestWithEnumeratorPasses()
	{
        //Check if the spawned object is the same as the Cromulon
		var spawnPoint = new GameObject().transform;
		spawn.Add(spawnPoint);

		var cromulonObject = Resources.Load("Cromulon") as GameObject;
		var spawner = new GameObject().AddComponent<CromulonSpawner>();
		spawner.Construct(spawn, 2f, cromulonObject);

        // Use the Assert class to test conditions.
        // yield to skip a frame
        yield return new WaitForSeconds(2);

		var cromulon = GameObject.FindWithTag("Cromulon");
		var spawnedObject = PrefabUtility.GetPrefabParent(cromulon);

		Assert.Equals(spawnedObject, cromulonObject);
    }
}
