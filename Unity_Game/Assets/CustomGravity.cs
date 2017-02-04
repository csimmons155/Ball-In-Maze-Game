using UnityEngine;
using System.Collections;

public class CustomGravity : MonoBehaviour {

	public float grav = 380;

	// Use this for initialization
	void Start () {

		if (Screen.orientation == ScreenOrientation.LandscapeLeft) {
			Debug.Log ("LEFT");
		} else if (Screen.orientation == ScreenOrientation.LandscapeRight) {
			Debug.Log ("RIGHT");
		} else if (Screen.orientation == ScreenOrientation.Portrait) {
			Debug.Log ("PORTRAIT");
		}

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Physics.gravity = new Vector3 (Input.acceleration.x * grav, Input.acceleration.y * grav, -Input.acceleration.z * grav);

	
	}
}
