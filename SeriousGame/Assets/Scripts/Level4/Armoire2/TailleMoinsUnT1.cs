﻿using UnityEngine;
using System.Collections;

public class TailleMoinsUnT1 : MonoBehaviour {

	public static bool valide = false;

	void OnTriggerEnter(Collider col){
		if (col.name.Contains ("Nombre")) {
			int tmp = int.Parse (col.name.Substring (6,1));
			if (TailleTableau.tailleDuTableau - tmp == 1) {
				valide = true;
				Instantiate (col.gameObject, new Vector3 (69.23f, 2.5f, -8.255f), Quaternion.identity);
				Destroy(col.gameObject.GetComponent<APorter>());
				Destroy (col.gameObject.GetComponent<Rigidbody> ());
				Destroy (gameObject);
			} else
				valide = false;
		}
		Debug.Log ("n-1 : " + valide);
	}
}
