using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour
{
	public static int health;
	private int maxHealth = 100;
	private Slider healthBar;

    // Use this for initialization
    void Awake()
    {
		healthBar = GetComponent<Slider>();
		health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
		healthBar.value = health;
    }
}
