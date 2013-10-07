using UnityEngine;
using System.Collections;

public class SphereScript : MonoBehaviour {

	void OnTriggerEnter()
	{
		networkView.RPC("hit",RPCMode.AllBuffered,new Vector3(1,0,0));
		Debug.Log("hit");
	}
	
	[RPC]
	void hit (Vector3 color)
	{
		renderer.material.color = new Color(color.x, color.y, color.z, 1);
	}
}
