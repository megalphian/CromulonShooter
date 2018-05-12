using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour
{
	private bool isGameOver;
	private Text GameOverText;
	[SerializeField] private PlayerHealth health;
   
    void Start()
	{
		GameOverText = gameObject.GetComponent<Text>();
		GameOverText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
		if (health.getHealth() <= 0){
		    GameOverText.enabled = true;
		}
    }
}
