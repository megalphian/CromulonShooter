using UnityEngine;
using System.Collections;

public class FpvControl : MonoBehaviour
{
	private Vector3 cameraRotation;
	private float x, y;

	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

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
