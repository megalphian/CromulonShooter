using UnityEngine;
using System.Collections;

public class CromulonDeath : MonoBehaviour
{
	bool isHit;

  //  // Use this for initialization
    void OnTriggerEnter(Collider newObject)
    {
		isHit = true;
    }

    // Update is called once per frame
    void Update()
    {
		if (isHit){
			Destroy(gameObject);
		}
    }
}
