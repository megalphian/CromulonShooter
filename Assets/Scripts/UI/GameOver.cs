using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour
{
	static public bool isGameOver;
    // Use this for initialization
    void Awake()
    {
		gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
		if(isGameOver){
			gameObject.SetActive(true);
		}

    }
}
