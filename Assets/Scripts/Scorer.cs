using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scorer : MonoBehaviour
{
	public static int score;
	private Text headerText;

    // Use this for initialization
    void Awake()
    {
		headerText = GetComponent<Text>();
		score = 0;
    }

	public void addScore(int addValue){
		score += addValue;
	}

    // Update is called once per frame
    void Update()
    {
		headerText.text = "Schwifty Points: " + score;
    }
}
