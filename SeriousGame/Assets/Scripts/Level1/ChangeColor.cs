using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

	GameObject dominoCourant;
	GameObject[] dominos = new GameObject[6];
	public static int[] verification = new int[6];
	Color[] colors = { Color.red, Color.blue, Color.green };//, Color.red, Color.green, Color.blue };
	Color currentColor;

	// Use this for initialization

	void Start () {

		dominoCourant = GameObject.Find ("Domino" + Iterations._iteration);
		//dominos [0] = GameObject.Find ("Domino0");
		//dominos [0].GetComponent<Rigidbody> ().isKinematic = true;
		for (int i = 0; i <= 5; i++) {
			dominos [i] = GameObject.Find ("Domino" + i);
			dominos [i].GetComponent<Rigidbody> ().isKinematic = true;
			verification [i] = 0;
		}
	}

	void OnTriggerEnter(Collider col) {
		currentColor = col.gameObject.GetComponent<Renderer> ().material.color;
		if(currentColor==Color.red||currentColor==Color.green||currentColor==Color.blue)
			if((Iterations._iteration>1 && verification[Iterations._iteration-2]==1) || Iterations._iteration==1)
				dominoCourant.GetComponent<Renderer> ().material.color = currentColor;
	}

	// Update is called once per frame
	void Update () {		
		if (LevelManager._level == 1) {
			dominoCourant = GameObject.Find ("Domino" + (Iterations._iteration - 1));
			if (dominoCourant.name == "Domino0" && currentColor == colors [0]) {//Color.red) {
				dominoCourant.gameObject.GetComponent<Rigidbody> ().AddForce (0, 0, -10);
				dominos [0].GetComponent<Rigidbody> ().isKinematic = false;
				verification [0] = 1;
			}
			for (int i = 1; i <= 5; i++) {
				if (dominoCourant == dominos [i] && currentColor == colors [i%3] && verification[i-1] == 1) {
					dominos[i].GetComponent<Rigidbody> ().isKinematic = false;
					verification [i] = 1;
				}
			}
		}
	}
}
