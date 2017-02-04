using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	private int count; 
	public Text countText;
	public Text winText;

	void Start(){

		count = 0; 
		SetCountText ();
		winText.text = "";

	}

	// Use this for initialization
	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("Coin")) {
			other.gameObject.SetActive (false);
			count = count + 1; 
			SetCountText ();
		}
		
	}

	void SetCountText(){

		countText.text = "Score: " + count.ToString();
		if(count >= 10){

			winText.text = "You Win!!";
		}

	}


}
