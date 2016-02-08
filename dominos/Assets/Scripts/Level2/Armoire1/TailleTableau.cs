﻿using UnityEngine;
using System.Collections;

public class TailleTableau : MonoBehaviour {

	public static int tailleDuTableau;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.name.Contains ("Nombre")) {
			tailleDuTableau = int.Parse (col.name.Substring (6));
			Instantiate (col.gameObject, new Vector3 (17f, 2f, -8f), Quaternion.identity);
			Destroy(col.gameObject.GetComponent<APorter>());
			Destroy (col.gameObject.GetComponent<Rigidbody> ());
			Destroy (gameObject);
		} else
			tailleDuTableau = -1;
		Debug.Log ("n : " + tailleDuTableau);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}