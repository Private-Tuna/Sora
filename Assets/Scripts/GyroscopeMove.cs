using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroscopeMove : MonoBehaviour
{
	public float speed;

	private Rigidbody rb;

	void Start()
	{
		speed = 4f;
		rb = GetComponent<Rigidbody>();
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}

	void FixedUpdate()
	{
		if (SystemInfo.deviceType == DeviceType.Desktop)
		{
			float moveHorizontal = Input.GetAxis("Horizontal");
			float moveVertical = Input.GetAxis("Vertical");

			Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

			rb.AddForce(movement * speed);
		}
		else
		{
			float moveH = Input.acceleration.x;
			float moveV = Input.acceleration.y;

			Vector3 movement = new Vector3(moveH, 0.0f, moveV);

			rb.AddForce(movement * speed * Time.deltaTime);
		}
	}
}
