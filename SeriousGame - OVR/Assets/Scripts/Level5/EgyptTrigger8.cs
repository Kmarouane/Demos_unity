using UnityEngine;
using System.Collections;

public class EgyptTrigger8 : MonoBehaviour {

	string colliderName;
	string colliderRealName;
	int colliderLength;
	string[] reff = { "DecrementerX2", "TailleY" };
	int objectToInt;

	public static int distance8 = 0;
	bool modified;

	void Start (){
		objectToInt = int.Parse (gameObject.name.Substring (5));
	}

	void OnTriggerEnter(Collider col) {
		if (col.name.Contains ("Cube")) {
			colliderLength = col.name.Length;
			colliderName = col.name;
			colliderRealName = colliderName.Substring (4, colliderLength - 4);

			if (colliderRealName == reff [objectToInt - 26] && !modified) {
				distance8++;
				modified = true;
			}
			Debug.Log (distance8);
		}
	}
}
