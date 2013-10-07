using UnityEngine;
using System.Collections;

public class BoxMovement : MonoBehaviour 
{
	int speed = 5;

	// Use this for initialization
	void Start () 
	{
		 
	}
	
	// Update is called once per frame
	void Update () 
	{	
		if(networkView.isMine)
		{
			transform.Translate(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed,
											0,
											Input.GetAxis("Vertical") * Time.deltaTime * speed));	
		}
		else
		{
			enabled = false;
		}
	}
}
