using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBrownRobot : MonoBehaviour {


	private Color colorLaser = new Color(0.05f,0.55f,0.23f);
	public int   DistanceLaser = 5000;
	private float initialWidth = 0.05f;
	private float finalWidth = 0.05f;
	private LineRenderer lineRenderer;
	private GameObject collitionLight;
	private Vector3 lightPosition;
	private bool isActive = false;
	private bool hasHitten = false;
	private GameObject lastHitted;

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
				lastHitted.SendMessage ("isBeingHit", "turquose");
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
		if (color == "green") {
			isActive = true;
			lineRenderer.enabled = true;
		}
	}

	void isNotBeingHit(string color) {
		print (color);
		isActive = false;
		print("Not");
		lineRenderer.enabled = false;
	}

	void shutdown() {
		if (hasHitten) {
			lastHitted.SendMessage ("isNotBeingHit", "turquose");
		}
		hasHitten = false;
	}
}
