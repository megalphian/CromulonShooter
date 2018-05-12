using UnityEngine;
using System.Collections;

public class CromulonDeath : MonoBehaviour
{
	private bool isHit;

	public int scoreValue = 10;
	public delegate void DeathAction(int scoreValue);
	public static event DeathAction OnDeath;

	void OnTriggerEnter(Collider _)
    {
		isHit = true;
    }

    // Check if the Cromulon has been hit every frame
    void Update()
    {
		if (isHit){
			Destroy(gameObject);
			if (OnDeath != null){
				OnDeath(scoreValue);
			}
		}
    }
}
