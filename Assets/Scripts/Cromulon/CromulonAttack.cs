using UnityEngine;
using System.Collections;

public class CromulonAttack : MonoBehaviour
{

	public int attackAmount = 10;
	public GameObject player;
	
	private PlayerHealth playerHealth;

  // Define 
  void Awake(){
		playerHealth = player.GetComponent<PlayerHealth> ();
  }

	void AttackPlayer(){
		if (playerHealth.getHealth() > 0) {
			playerHealth.TakeDamage(attackAmount);
		}
	}

  //Once per frame, check for Cromulon's position
  //If it reaches the end of the path specified in the Movement script, deal damage to player and disapper
  void Update(){
		if (transform.position.z <= (GetComponent<CromulonMovement>().getThreshold() + 2)){
			AttackPlayer();
			Destroy(gameObject);
		}
    }
}
