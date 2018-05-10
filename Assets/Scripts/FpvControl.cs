using UnityEngine;
using System.Collections;

public class FpvControl : MonoBehaviour
{
	private Vector3 cameraRotation;
	private float x, y;


    // Initializing Camera Position
    void Start()
    {
		//cameraObject = Camera.main;
		//cameraPosition = cameraObject.transform.localPosition;
    }

    void RotateCam(float x, float y)
	{
		cameraRotation.Set(x, -y, 0f);
		transform.eulerAngles -= cameraRotation;
	}

    // FixedUpdate is called every time the mouse is moved
    void FixedUpdate()
    {
		x = Input.GetAxis("Mouse Y");
		y = Input.GetAxis("Mouse X");
		Debug.Log("Current Axis" + x + " : " + y);

		RotateCam(x, y);
    }
}
