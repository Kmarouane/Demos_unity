﻿using UnityEngine;
using System.Collections;

public class BoolScript : MonoBehaviour {

	public static bool value;
	public static bool valide = false;
	int taille;

	// Use this for initialization
	void Start(){
		
	}

	void OnTriggerEnter(Collider col){
		if (col.name.Contains ("True"))
			taille = 4;
		else if (col.name.Contains ("False"))
			taille = 5;
		if (col.name.Contains ("True") || col.name.Contains ("False")) {
			valide = true;
			string tmp = col.name.ToLower ().Substring (5, taille);
			value = bool.Parse (tmp);
			Instantiate (col.gameObject, new Vector3 (83.38f, 1.479f, -7.094f), Quaternion.identity);
			Destroy(col.gameObject.GetComponent<APorter>());
			Destroy (col.gameObject.GetComponent<Rigidbody> ());
			Destroy (gameObject);
		} else
			valide = false;
		Debug.Log (valide);
	}
}
