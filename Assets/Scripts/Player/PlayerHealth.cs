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
		ui = GameObject.FindGameObjectWithTag("UI");
		ui.transform.GetChild(0).gameObject.SetActive(false);
    }
    
	void PlayerDeath(){
		
	}

	public void TakeDamage(int damageAmount){
		currentHealth -= damageAmount;
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
