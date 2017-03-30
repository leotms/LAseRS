using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour {

	public bool isActive = false;
	private GameObject Engine;
	// Use this for initialization
	void Start () {
		Engine = this.gameObject.transform.GetChild(0).gameObject;
		Engine.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("return")) {
			isActive = true;
			Engine.SetActive (true);
			this.GetComponent<AudioSource>().Play ();
		}

		if (isActive) {
			transform.Translate(Vector3.up * Time.deltaTime);
		}
	}

	void Launch(){
		isActive = true;
		Engine.SetActive (true);
		this.GetComponent<AudioSource>().Play ();
	}
}
