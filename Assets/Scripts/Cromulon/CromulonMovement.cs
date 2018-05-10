using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CromulonMovement : MonoBehaviour {

	private Vector3 EndPosition;
	private float speed = 0.5f;
	private float z_threshold = -12f;

	// Use this for initialization
	private void Move () {
		EndPosition.Set(transform.position.x, transform.position.y, z_threshold);
		transform.position = Vector3.Lerp(transform.position, EndPosition, Time.deltaTime*speed);
	}

	public float getThreshold(){
		return z_threshold;
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}
}
