using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CromulonMovement : MonoBehaviour {

	private Vector3 EndPosition;
	private float speed = 0.5f;

	// Use this for initialization
	private void Move () {
		EndPosition.Set(transform.position.x, transform.position.y, -12);
		transform.position = Vector3.Lerp(transform.position, EndPosition, Time.deltaTime*speed);
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}
}
