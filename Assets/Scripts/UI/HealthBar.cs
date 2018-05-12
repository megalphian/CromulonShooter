using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour
{
	public int maxHealth = 100;
	private Slider healthBar;

	private void OnEnable()
    {
        PlayerHealth.changeHealth += UpdateHealth; //Change
    }

    private void OnDisable()
    {
        PlayerHealth.changeHealth -= UpdateHealth; //Change
    }

    // Use this for initialization
    void Awake()
    {
		healthBar = GetComponent<Slider>();
		healthBar.value = maxHealth;
    }
       
    // Update is called once per frame
    void UpdateHealth(int health)
	{
		healthBar.value = health;
    }
}
