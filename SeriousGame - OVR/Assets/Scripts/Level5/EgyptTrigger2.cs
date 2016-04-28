﻿using UnityEngine;
using System.Collections;

public class EgyptTrigger2 : MonoBehaviour {

	string colliderName;
	string colliderRealName;
	int colliderLength;
	string[] reff = { "Pour", "I", "AllantDe", "0", "A", "TailleX" };
	int objectToInt;

	public static int distance2 = 0;
	bool modified;

	void Start (){
		objectToInt = int.Parse (gameObject.name.Substring (5));
	}

	void OnTriggerEnter(Collider col) {
		if (col.name.Contains ("Cube")) {
			colliderLength = col.name.Length;
			colliderName = col.name;
			colliderRealName = colliderName.Substring (4, colliderLength - 4);

			if (colliderRealName == reff [objectToInt % 6] && !modified) {
				distance2++;
				modified = true;
			}
			Debug.Log (distance2);
		}
	}
}
