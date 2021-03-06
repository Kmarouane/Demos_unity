﻿using UnityEngine;
using System.Collections;

public class EgyptTrigger4 : MonoBehaviour {

	string colliderName;
	string colliderRealName;
	int colliderLength;
	string[] reff = { "Pierre", "X-J", "Y+K", "Z+I" };
	int objectToInt;

	public static int distance4 = 0;
	bool modified;

	void Start (){
		objectToInt = int.Parse (gameObject.name.Substring (5));
	}

	void OnTriggerEnter(Collider col) {
		if (col.name.Contains ("Cube")) {
			colliderLength = col.name.Length;
			colliderName = col.name;
			colliderRealName = colliderName.Substring (4, colliderLength - 4);

			if (colliderRealName == reff [objectToInt - 18] && !modified) {
				distance4++;
				modified = true;
			}
			Debug.Log (distance4);
		}
	}
}
