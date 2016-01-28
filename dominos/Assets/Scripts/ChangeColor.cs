using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

	GameObject dominoCourant;
	GameObject[] dominos = new GameObject[6];
	Color[] colors = { Color.red, Color.green, Color.blue, Color.red, Color.green, Color.blue };
	//public Iterations its;
	Color currentColor;

	// Use this for initialization

	void Start () {
		dominoCourant = GameObject.Find ("Domino" + Iterations._iteration);//its.getIteration());
		dominos [0] = GameObject.Find ("Domino0");
		dominos [0].GetComponent<Rigidbody> ().isKinematic = true;
		for (int i = 1; i <= 5; i++) {
			dominos [i] = GameObject.Find ("Domino" + i);
			dominos [i].GetComponent<Rigidbody> ().isKinematic = true;
		}
	}

	void OnTriggerEnter(Collider col) {
		currentColor = col.gameObject.GetComponent<Renderer> ().material.color;
		if(currentColor==Color.red||currentColor==Color.green||currentColor==Color.blue)
			dominoCourant.GetComponent<Renderer> ().material.color = currentColor;
	}

	// Update is called once per frame
	void Update () {
		dominoCourant = GameObject.Find ("Domino" + (Iterations._iteration - 1));//its.getIteration()-1));
		if (dominoCourant.name == "Domino0" && currentColor == Color.red) {
			dominoCourant.gameObject.GetComponent<Rigidbody> ().AddForce (0, 0, -10);
		}
		for (int i = 0; i <= 5; i++) {
			if (dominoCourant == dominos [i] && currentColor == colors [i]) {
				dominos[i].GetComponent<Rigidbody> ().isKinematic = false;
			}
		}
	}
}
