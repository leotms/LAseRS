using System.Collections;
using UnityEngine;

public class LaserMirror : MonoBehaviour {

	public Color colorLaser = Color.blue;
	public int   DistanceLaser = 5000;
	private float initialWidth = 0.05f;
	private float finalWidth = 0.05f;
	private LineRenderer lineRenderer;
	private GameObject collitionLight;
	private Vector3 lightPosition;
	private bool isActive = false;
	private bool hasHitten = false;
	private GameObject lastHitted;

	private string color1 = "";
	private string color2 = "";
	private string sendcolor = "";

	// Use this for initialization
	void Start () {
		collitionLight = new GameObject ();
		collitionLight.AddComponent <Light> ();
		collitionLight.GetComponent<Light> ().intensity = 8;
		collitionLight.GetComponent<Light> ().bounceIntensity = 8;
		collitionLight.GetComponent<Light> ().range = finalWidth * 2;
		collitionLight.GetComponent<Light> ().color = colorLaser;

		lineRenderer = gameObject.AddComponent<LineRenderer> ();
		lineRenderer.material = new Material (Shader.Find ("Particles/Additive"));
		lineRenderer.startColor = colorLaser;
		lineRenderer.endColor = colorLaser;
		lineRenderer.startWidth = initialWidth;
		lineRenderer.endWidth = finalWidth;
		lineRenderer.numPositions = 2;
		lineRenderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (this.gameObject.activeSelf && !isActive) {
			lineRenderer.enabled = false;
		}

		Vector3 LaserFinalPoint = transform.position + transform.forward * DistanceLaser;
		RaycastHit collisionPoint;
		if (Physics.Raycast (transform.position, transform.forward, out collisionPoint)) {
			if (isActive) {
				hasHitten = true;
				lastHitted = collisionPoint.transform.gameObject;
				GetComponent<LineRenderer> ().SetPosition (0, transform.position);
				GetComponent<LineRenderer> ().SetPosition (1, collisionPoint.point  + collisionPoint.point*0.05f);
				lastHitted.SendMessage ("isBeingHit", sendcolor);
			}
		} else {
			if (isActive) {
				shutdown ();
				GetComponent<LineRenderer> ().SetPosition (0, transform.position);
				GetComponent<LineRenderer> ().SetPosition (1, LaserFinalPoint);		
			}
		}

	}

	void OnCollisionEnter (Collision col) {
		print (col.gameObject.name);
	}

	void isBeingHit(string color) {
		
		isActive = true;
		lineRenderer.enabled = true;

		if (color1 == "") {
			color1 = color;
			if (color == "blue") {
				lineRenderer.startColor = Color.blue;
				lineRenderer.endColor = Color.blue;
				sendcolor = "blue";
			} else if  (color == "red") {
				lineRenderer.startColor = Color.red;
				lineRenderer.endColor = Color.red;
				sendcolor = "red";
			} else if  (color == "yellow") {
				lineRenderer.startColor = Color.yellow;
				lineRenderer.endColor = Color.yellow;
				sendcolor = "yellow";
			}
		} else if (color2 == "") {
			if (color1 == "blue" && color == "yellow") {
				color2 = "green";
				lineRenderer.startColor = Color.green;
				lineRenderer.endColor = Color.green;
				sendcolor = "green";
			} else if (color1 == "yellow" && color == "blue") {
				color2 = "green";
				lineRenderer.startColor = Color.green;
				lineRenderer.endColor = Color.green;
				sendcolor = "green";
			} else if  (color1 == "red"  && color == "yellow") {
				color2 = "orange";
				lineRenderer.startColor = new Color(0.78f, 0.47f, 0.15f);
				lineRenderer.endColor = new Color(0.78f, 0.47f, 0.15f);
				sendcolor = "orange";
			} else if  (color1 == "yellow"  && color == "red") {
				color2 = "orange";
				lineRenderer.startColor = new Color(0.78f, 0.47f, 0.15f);
				lineRenderer.endColor = new Color(0.78f, 0.47f, 0.15f);
				sendcolor = "orange";
			} else if  (color1 == "red"  && color == "blue") {
				color2 = "purple";
				lineRenderer.startColor = new Color(0.63f,0.13f,0.94f);
				lineRenderer.endColor = new Color(0.63f,0.13f,0.94f);
				sendcolor = "purple";
			} else if  (color1 == "blue"  && color == "red") {
				color2 = "purple";
				lineRenderer.startColor =new Color(0.63f,0.13f,0.94f);
				lineRenderer.endColor = new Color(0.63f,0.13f,0.94f);
				sendcolor = "purple";
			}
		}

		print("Hitted");

	}

	void isNotBeingHit(string color) {
		isActive = false;
		print("Not");
		lineRenderer.enabled = false;
		if (color2 != "") {
			if (color2 == "orange" && color == "red") {
				lineRenderer.startColor = Color.yellow;
				lineRenderer.endColor = Color.yellow;
				sendcolor = "yellow";
				color1 = "yellow";
			} else if (color2 == "orange" && color == "yellow") {
				lineRenderer.startColor = Color.red;
				lineRenderer.endColor = Color.red;
				sendcolor = "red";
				color1 = "red";
			} else if  (color2 == "green" && color == "yellow") {
				lineRenderer.startColor = Color.blue;
				lineRenderer.endColor = Color.blue;
				sendcolor = "blue";
				color1 = "blue";
			} else if (color2 == "green" && color == "blue") {
				lineRenderer.startColor = Color.yellow;
				lineRenderer.endColor = Color.yellow;
				sendcolor = "yellow";
				color1 = "yellow";
			} else if  (color2 == "purple" && color == "blue") {
				lineRenderer.startColor = Color.red;
				lineRenderer.endColor = Color.red;
				sendcolor = "red";
				color1 = "red";
			} else if (color2 == "purple" && color == "red") {
				lineRenderer.startColor = Color.blue;
				lineRenderer.endColor = Color.blue;
				sendcolor = "blue";
				color1 = "blue";
			}
			color2 = "";
		} else {
			color1 = "";
		}
	}

	void shutdown() {
		if (hasHitten) {
			lastHitted.SendMessage ("isNotBeingHit", sendcolor);
		}
		hasHitten = false;
	}
}
