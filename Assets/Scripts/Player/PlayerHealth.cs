using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    
	public int maxHealth = 100;
	public Canvas ui;
	public delegate void HealthBar(int health);
	public static event HealthBar changeHealth;

	private int currentHealth;

	private bool isDead;
    
    // Use this for initialization
    void Awake()
	{
		currentHealth = maxHealth;
		ui.transform.GetChild(0).gameObject.SetActive(false);
    }
    
	void PlayerDeath(){
		GameOver.isGameOver = true; //change
	}

	public void TakeDamage(int damageAmount){
		currentHealth -= damageAmount;
		if (changeHealth != null)
        {
            changeHealth(currentHealth);
        }
		if (currentHealth <= 0){
			PlayerDeath();
		}
	}

	public int getHealth(){
		return currentHealth;
	}

}
