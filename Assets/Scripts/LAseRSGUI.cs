using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAseRSGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onGUI(){
		GUI.Box(new Rect(50, 50, 100, 90), "Hello, World!");
		if (GUI.Button(new Rect(10, 10, 150, 100), "I am a button"))
			print("You clicked the button!");
	}
}
