using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
	private int currentHealth;

	public int maxHealth = 100;

	public delegate void Damaged(int health);
	public static event Damaged ChangeHealth;
    

    // Initalize Health 
    void Awake()
	{
		currentHealth = maxHealth;
    }
       
    //Take Damage if Cromulon passes through
	public void TakeDamage(int damageAmount){
		currentHealth -= damageAmount;
		if (currentHealth <= 0)
        {
    		currentHealth = 0;
        }
		if (ChangeHealth != null)
        {
            ChangeHealth(currentHealth);
        }
	}
    
    //Get health property
	public int getHealth(){
		return currentHealth;
	}

}
