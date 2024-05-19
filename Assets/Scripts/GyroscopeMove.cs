using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroscopeMove : MonoBehaviour
{
	public float speed;

	private Rigidbody rb;

	void Start()
	{
		Input.gyro.enabled = true;
		speed = 4f;
		rb = GetComponent<Rigidbody>();
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}

	void FixedUpdate()
	{
		/*
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
		}*/
		Vector3 direction = Vector3.zero;
		Debug.Log(Input.gyro.attitude);
		Quaternion orientation = Input.gyro.attitude;
		Vector3 angles = orientation.eulerAngles;
		Debug.Log("angles: x = " + angles.x + " y = " + angles.y);

		float threshold = 180;
		//float x = Input.acceleration.x;
		//float y = Input.acceleration.y;
		//int xdir = 0;
		//if (angles.x >180){
        //	xdir = angles.x - 360;
        //}
		if (angles.x > threshold && angles.x > 10)
		{
			direction += Vector3.right;
		}
 
		else if (angles.x < threshold && angles.x <350)
		{
			direction += Vector3.left;
		}
 
		if (angles.y > threshold && angles.y > 10)
		{
			direction += Vector3.forward;
		}
 
		else if (angles.y < threshold && angles.y < 350)
		{
			direction += Vector3.back;
		}      
		/*
		 * if (xdir>-10 && xdir<10)
		 * {
		 *		rb.angularVelocity.x = 0;
		 * }
		 */
		//Debug.Log("direction: " + direction.ToString());
		rb.AddTorque(direction * speed);     
		
	}
}
