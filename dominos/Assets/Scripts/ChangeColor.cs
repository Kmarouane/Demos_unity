using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

	GameObject dominoCourant;
	GameObject[] dominos = new GameObject[6];
	Color[] colors = { Color.red, Color.green, Color.blue, Color.red, Color.green, Color.blue };
	public Iterations its;
	Color currentColor;

	// Use this for initialization

	void Start () {
		dominoCourant = GameObject.Find ("Domino" + its.getIteration());
		dominos [0] = GameObject.Find ("Domino0");
		for (int i = 1; i <= 5; i++) {
			dominos [i] = GameObject.Find ("Domino" + i);
			dominos [i].GetComponent<Rigidbody> ().isKinematic = true;
		}
	}

	void OnTriggerEnter(Collider col) {
		dominoCourant.GetComponent<Renderer> ().material.color = col.gameObject.GetComponent<Renderer> ().material.color;
		currentColor = dominoCourant.GetComponent<Renderer> ().material.color;
	}

	// Update is called once per frame
	void Update () {
		dominoCourant = GameObject.Find ("Domino" + (its.getIteration()-1));
		if (dominoCourant.name == "Domino0" && currentColor == Color.red) {
			dominoCourant.gameObject.GetComponent<Rigidbody> ().AddForce (0, 0, -10);
		}
		for (int i = 1; i <= 5; i++) {
			if (dominoCourant == dominos [i] && currentColor == colors [i]) {
				dominos[i].GetComponent<Rigidbody> ().isKinematic = false;
			}
		}
	}
}
