using UnityEngine;
using System.Collections;

public class CromulonDeath : MonoBehaviour
{
	private bool isHit;

	public int scoreValue = 10;
	public delegate void DeathAction(int scoreValue);
	public static event DeathAction onDeath;

	void OnTriggerEnter(Collider _)
    {
		isHit = true;
    }

    // Update is called once per frame
    void Update()
    {
		if (isHit){
			Destroy(gameObject);
			if (onDeath != null){
				onDeath(scoreValue);
			}
		}
    }
}
