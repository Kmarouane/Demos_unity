using UnityEngine;
using System.Collections;

public class Iterations : MonoBehaviour {

	public static int _iteration = 1;
	GameObject suivant;
	Vector3 s_position;
	GameObject precedent;
	Vector3 p_position;

	// Use this for initialization

	void Start () {
		suivant = GameObject.Find ("SuivantCube");
		precedent = GameObject.Find ("PrecedentCube");
		s_position = suivant.transform.position;
		p_position = precedent.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C) && _iteration<6) {
			_iteration++;
		}
		if (Input.GetKeyDown (KeyCode.V) && _iteration>1) {
			_iteration--;
		}
	}

	void OnTriggerEnter(Collider col) { // use invoke
		if (col.gameObject == suivant && _iteration<6) {
			StartCoroutine(Attendre());
			_iteration++;
		}
		if (col.gameObject == precedent && _iteration>1) {
			StartCoroutine(Attendre());
			_iteration--;
		}
		suivant.transform.position = s_position;
		precedent.transform.position = p_position;
	}

	IEnumerator Attendre() {
		yield return new WaitForSeconds(5);
	}
}
