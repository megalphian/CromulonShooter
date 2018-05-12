using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour
{
	private Slider healthBar;

	[SerializeField] private int maxHealth = 100;

    //Add the Update Health function to the Event Manager to subscribe to the Player's damage even
	private void OnEnable()
    {
        PlayerHealth.ChangeHealth += UpdateHealth; //Change
    }

    private void OnDisable()
    {
        PlayerHealth.ChangeHealth -= UpdateHealth; //Change
    }

    // Initalize the Slider
    void Awake()
    {
		healthBar = GetComponent<Slider>();
		healthBar.value = maxHealth;
    }
       
    // Update health once per frame
    void UpdateHealth(int health)
	{
		healthBar.value = health;
    }
}
