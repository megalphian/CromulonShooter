﻿using UnityEngine;
using System.Collections;

public class CromulonAttack : MonoBehaviour
{
	public int attackAmount = 10;
	public GameObject player;
	private PlayerHealth playerHealth;

    // Use this for initialization
    void Awake()
    {
		player = GameObject.FindGameObjectWithTag("Player");
		//playerHealth = player.GetComponent<PlayerHealth> ();
    }
   
    // Update is called once per frame
    void Update()
    {
		if (transform.position.z <= GetComponent<CromulonMovement>().getThreshold() + 1){
			Destroy(gameObject);
		}
    }
}
