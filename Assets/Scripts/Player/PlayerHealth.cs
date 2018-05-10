using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{

	private int startingHealth = 100;
	private int currentHealth;

    // Use this for initialization
    void Awake()
    {
		currentHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
