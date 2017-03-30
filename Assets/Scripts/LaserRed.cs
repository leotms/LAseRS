using System.Collections;
using UnityEngine;

public class LaserRed : MonoBehaviour {

	private Color colorLaser =  Color.red;
	public int   DistanceLaser = 5000;
	private float initialWidth = 0.05f;
	private float finalWidth = 0.05f;
	private GameObject collitionLight;
	private Vector3 lightPosition;
	private bool hasHitten = false;
	private GameObject lastHitted;


	// Use this for initialization
	void Start () {
		collitionLight = new GameObject ();
		lastHitted = collitionLight;
		collitionLight.AddComponent <Light> ();
		collitionLight.GetComponent<Light> ().intensity = 8;
		collitionLight.GetComponent<Light> ().bounceIntensity = 8;
		collitionLight.GetComponent<Light> ().range = finalWidth * 2;
		collitionLight.GetComponent<Light> ().color = colorLaser;

		LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer> ();
		lineRenderer.material = new Material (Shader.Find ("Particles/Additive"));
		lineRenderer.startColor = colorLaser;
		lineRenderer.endColor = colorLaser;
		lineRenderer.startWidth = initialWidth;
		lineRenderer.endWidth = finalWidth;
		lineRenderer.numPositions = 2;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 LaserFinalPoint = transform.position + transform.forward * DistanceLaser;
		RaycastHit collisionPoint;
		if (Physics.Raycast (transform.position, transform.forward, out collisionPoint)) {
			lastHitted = collisionPoint.transform.gameObject;
			hasHitten = true;
			GetComponent<LineRenderer> ().SetPosition (0, transform.position);
			GetComponent<LineRenderer> ().SetPosition (1, collisionPoint.point + collisionPoint.point*0.05f);
			lastHitted.SendMessage ("isBeingHit", "red");
		} else {
			shutdown ();
			GetComponent<LineRenderer> ().SetPosition (0, transform.position);
			GetComponent<LineRenderer> ().SetPosition (1, LaserFinalPoint);
		}

	}

	void shutdown() {
		if (hasHitten) {
			lastHitted.SendMessage ("isNotBeingHit", "red");
		}

		hasHitten = false;
	}
}
