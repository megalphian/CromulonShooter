using UnityEngine;
using System.Collections;

public class CromulonAttack : MonoBehaviour
{
	private GameObject player;
    private PlayerHealth playerHealth;

	public int attackAmount = 10;
	public string GameObjectTag = "Player";

    // Get the player's health object to damage the player
    private void Awake(){

		player = GameObject.FindGameObjectWithTag(GameObjectTag);
		playerHealth = player.GetComponent<PlayerHealth> ();

    }

    //Make player take damage when the Cromulon has reached the player
	private void AttackPlayer(){
		if (playerHealth.getHealth() > 0) {
			playerHealth.TakeDamage(attackAmount);
		}
	}

    //Once per frame, check for Cromulon's position
    //If it reaches the end of the path specified in the Movement script, deal damage to player and disapper
    private void Update(){
		if (transform.position.z <= (GetComponent<CromulonMovement>().getThreshold() + 2)){
			AttackPlayer();
			Destroy(gameObject);
		}
    }
}
