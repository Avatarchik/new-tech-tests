using UnityEngine;
using System.Collections;

public class LocationTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Input.location.Start();
	}
	
	// Update is called once per frame
	void OnGUI () {
		if(Input.location.status == LocationServiceStatus.Running){
			GUI.TextArea(new Rect(0, 0, Screen.width, Screen.height), LocationInfo2String(Input.location.lastData));
		}
	}
	
	private string LocationInfo2String(LocationInfo l){
		string s = "";
		s += "Longitude: "+ l.longitude + "\n";
		s += "Latitude: "+ l.latitude + "\n";
		s += "Altitude: "+ l.altitude + "\n";
		s += "TimeStamp: "+ l.timestamp + "\n";
		return s;
	}
}
