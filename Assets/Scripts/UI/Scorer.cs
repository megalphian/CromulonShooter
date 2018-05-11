using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scorer : MonoBehaviour
{
	private Text HeaderText;
	private int score;

	private void OnEnable()
	{
		CromulonDeath.onDeath += addScore;
	}

	private void OnDisable()
	{
		CromulonDeath.onDeath -= addScore;
	}

	// Use this for initialization
	void Awake()
	{
		
		HeaderText = GetComponent<Text>();
		score = 0;
    }

	private void Start()
	{
		HeaderText.text = "Schwifty Points: " + score;
	}

	public void addScore(int scoreValue){
		score += scoreValue;
		UpdateScore();
	}

    // Update is called once per frame
    void UpdateScore()
    {
		HeaderText.text = "Schwifty Points: " + score;
    }
}
