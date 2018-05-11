using UnityEngine;
using System.Collections;

public class CromulonDeath : MonoBehaviour
{
	bool isHit;
	private int scoreValue = 10;
    
	void OnTriggerEnter(Collider newObject)
    {
		isHit = true;
    }

    // Update is called once per frame
    void Update()
    {
		if (isHit){
			Destroy(gameObject);
			Scorer.score += scoreValue;
		}
    }
}
