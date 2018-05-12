using UnityEngine;
using System.Collections;

public class FpvControl : MonoBehaviour
{
	private Vector3 cameraRotation;
	private float x, y;

    //Lock cursor in the center of the screen and hid it at startup
	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

    //Rotate Camera function
	void RotateCam()
	{
		x = Mathf.Clamp(x, -90, 90);
		cameraRotation.Set(x, -y, 0f);
		transform.eulerAngles -= cameraRotation;

	}

    // FixedUpdate is called every time the mouse is moved
    void FixedUpdate()
    {
		x = Input.GetAxisRaw("Mouse Y");
		y = Input.GetAxisRaw("Mouse X");
		Debug.Log("Current Axis" + x + " : " + y);

		RotateCam();
    }
}
