using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchPad : MonoBehaviour {

	public GameObject Rocket;
	private GameObject panel1;
	private GameObject panel2;
	private int colvalue;
	private string launchColor = "";


	// Use this for initializatetion
	void Start () {
		int colvalue = Random.Range (4, 10);

		panel1 = this.transform.GetChild (8).gameObject;
		panel2 = this.transform.GetChild (9).gameObject;

		Color color = new Color (0f, 0f, 0f);
		if (colvalue == 4) {
			color = Color.green;
			launchColor = "green";
		} else if (colvalue == 5) {
			color = new Color(0.78f, 0.47f, 0.15f);
			launchColor = "orange";
		} else if (colvalue == 6) {
			color = new Color(0.63f,0.13f,0.94f);
			launchColor = "purple";
		} else if (colvalue == 7) {
			color = Color.cyan;
			launchColor = "cyan";
		} else if (colvalue == 8) {
			color = new Color(1f,0.43f,0.71f);
			launchColor = "pink";
		} else if (colvalue == 9) {
			color = new Color(0.05f,0.55f,0.23f);
			launchColor = "turquose";
		} 

	
		print (launchColor);

		panel1.GetComponent<Renderer> ().materials [0].SetColor("_Color", color);
		panel1.GetComponent<Renderer>().materials[1].SetColor("_Color", color);
		panel2.GetComponent<Renderer>().materials[0].SetColor("_Color", color);
		panel2.GetComponent<Renderer>().materials[1].SetColor("_Color", color);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void isBeingHit(string color) {
		if (color == launchColor) {
			Rocket.SendMessage ("Launch");
		} else {
			print ("Error");
		}
	}

	void isNoBeingHit(string color) {
		print (color);
	}
}
