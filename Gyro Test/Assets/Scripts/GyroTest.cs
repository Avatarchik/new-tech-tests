using UnityEngine;
using System.Collections;

public class GyroTest : MonoBehaviour {
	
	
	private Quaternion cameraCorrection = Quaternion.identity;
	private Quaternion initRotation = Quaternion.identity;
	
	// Use this for initialization
	void Start () {
		initRotation = this.transform.rotation;
		Input.gyro.enabled = true;
		CalculateCameraCorrection();
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Slerp(transform.rotation, //transform.rotation, 0.2f);
			new Quaternion(-Input.gyro.attitude.x, -Input.gyro.attitude.y, Input.gyro.attitude.z, Input.gyro.attitude.w) * cameraCorrection, 0.2f);
	}

	void CalculateCameraCorrection()
	{
		cameraCorrection = new Quaternion(-Mathf.Abs(initRotation.x - Input.gyro.attitude.x), 
			-Mathf.Abs(initRotation.y - Input.gyro.attitude.y), -Mathf.Abs(initRotation.z - Input.gyro.attitude.z), 
			-Mathf.Abs(initRotation.w - Input.gyro.attitude.w));
	}
}