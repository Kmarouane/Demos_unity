using UnityEngine;
using System.Collections;

public class Assenceur : MonoBehaviour {

	public Transform depart;
	public Transform arrivee;
	public float vitesse;
	bool butee = false;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (transform.position == arrivee.position) 
			butee = true;
		if (transform.position == depart.position)
			butee = false;

		int x = Screen.width / 2;
		int y = Screen.height / 2;


		if (butee && Input.GetKey(KeyCode.E)) {

			Ray ray = Camera.main.GetComponent<Camera> ().ScreenPointToRay (new Vector3 (x, y));
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				if (hit.collider.name == "BoutonAssenceur")
					transform.position = Vector3.MoveTowards (transform.position, depart.position, vitesse * Time.fixedDeltaTime);
			}

		} else if (!butee && Input.GetKey(KeyCode.A)) {

			Ray ray = Camera.main.GetComponent<Camera>().ScreenPointToRay(new Vector3(x,y));
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				if (hit.collider.name == "BoutonAssenceur")
					transform.position = Vector3.MoveTowards (transform.position, arrivee.position, vitesse * Time.fixedDeltaTime);
			}
		}
	}
}
