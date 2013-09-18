using UnityEngine;
using System.Collections;

public class Accelerometer : MonoBehaviour {
	
	public float speed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 	Vector3 dir = Vector3.zero;
        dir.z = Input.acceleration.y;
        dir.x = -Input.acceleration.x;
        if (dir.sqrMagnitude > 1)
            dir.Normalize();
        
        dir *= Time.deltaTime;
        transform.Translate(dir * speed * Time.deltaTime);
	}
}
