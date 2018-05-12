using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scorer : MonoBehaviour
{
	private Text HeaderText;
	private int score;
	[SerializeField] private PlayerHealth playerHealth;

	private void OnEnable()
	{
		CromulonDeath.OnDeath += addScore; //Add to Cromulon Death event when enabled
	}
    
	private void OnDisable()
	{
		CromulonDeath.OnDeath -= addScore; //Remove from Cromulon Death event when disabled
	}

	// Get instance of text compenent
	void Awake()
	{
		HeaderText = GetComponent<Text>();
		score = 0;
    }

    //Initalize Score header
	private void Start()
	{
		HeaderText.text = "Schwifty Points: " + score;
	}

    //Add score value when Cromulon dies from the projectile
	public void addScore(int scoreValue){
		if (playerHealth.getHealth() > 0){
			score += scoreValue;
			UpdateScore();
		}
	}

    // Update the score when cromulon dies
    void UpdateScore()
    {
		HeaderText.text = "Schwifty Points: " + score;
    }
}
