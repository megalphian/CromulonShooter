using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    
	private int startingHealth = 100;
	private int currentHealth;

	private bool isDead;
	private GameObject ui;
    
    // Use this for initialization
    void Awake()
    {
		currentHealth = startingHealth;
		HealthBar.health = currentHealth;
		ui = GameObject.FindGameObjectWithTag("UI");
		ui.transform.GetChild(0).gameObject.SetActive(false);
    }
    
	void PlayerDeath(){
		GameOver.isGameOver = true;
	}

	public void TakeDamage(int damageAmount){
		currentHealth -= damageAmount;
		HealthBar.health = currentHealth;
		if (currentHealth <= 0){
			PlayerDeath();
		}
	}

	public int getHealth(){
		return currentHealth;
	}


    // Update is called once per frame
    void Update()
    {

    }
}
