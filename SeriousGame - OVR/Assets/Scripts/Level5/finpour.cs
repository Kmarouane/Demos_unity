using UnityEngine;
using System.Collections;

public class finpour : MonoBehaviour {

	public static int distanceFinPour;
	bool modified;

	void OnTriggerEnter(Collider col) {
		if (col.name.Contains ("CubeFinPour")) {
			if (!modified) {
				distanceFinPour++;
				modified = true;
			}				
		}
	}
}
