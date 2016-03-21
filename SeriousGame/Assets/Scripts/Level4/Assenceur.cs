using UnityEngine;
using System.Collections;

public class Assenceur : MonoBehaviour {

	public Transform depart;
	public Transform arrivee;
	public float vitesse;
	//bool butee = false;

	// Update is called once per frame
	void FixedUpdate () {

		int x = Screen.width / 2;
		int y = Screen.height / 2;


		if (Input.GetKey(KeyCode.E)) {

			Ray ray = Camera.main.GetComponent<Camera> ().ScreenPointToRay (new Vector3 (x, y));
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				if (hit.collider.name == "BoutonAssenceur")
					transform.position = Vector3.MoveTowards (transform.position, depart.position, vitesse * Time.fixedDeltaTime);
			}

		} else if (Input.GetKey(KeyCode.A)) {

			Ray ray = Camera.main.GetComponent<Camera>().ScreenPointToRay(new Vector3(x,y));
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				if (hit.collider.name == "BoutonAssenceur")
					transform.position = Vector3.MoveTowards (transform.position, arrivee.position, vitesse * Time.fixedDeltaTime);
			}
		}
	}
}
