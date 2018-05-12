using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class SpawnerTest {

    [Test]
    public void SpawnerTestSimplePasses() {
        // Use the Assert class to test conditions.
    }

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator SpawnerTestWithEnumeratorPasses() {

		var cromulonSpawner = new GameObject().AddComponent<CromulonSpawner>();

		var cromulon = GameObject.FindWithTag("Cromulon");
		var cromulonPrefab = PrefabUtility.GetPrefabType(cromulon);
        
        yield return null;

        Assert.AreEqual(cromulonPrefab, spawnedPrefab)
    }
}
