using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CromulonMovement : MonoBehaviour {

	private Vector3 EndPosition;
	private float z_threshold = -12f;

	public float speed = 0.5f;

	private void Start()
	{
		EndPosition.Set(transform.position.x, transform.position.y, z_threshold);
	}

	// Function to handle movement
	private void Move () {
		transform.position = Vector3.Lerp(transform.position, EndPosition, Time.deltaTime*speed);
	}

	public float getThreshold(){
		return z_threshold;
	}
	
	// Update is called once per frame
	void Update() {
		//Move towards given goal every frame
		Move();
	}
}
