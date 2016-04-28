using UnityEngine;
using System.Collections;

public class EgyptTrigger1 : MonoBehaviour {

	string colliderName;
	string colliderRealName;
	int colliderLength;
	string[] reff = { "Pour", "K", "AllantDe", "0", "A", "TailleZ" };
	int objectToInt;

	public static int distance1 = 0;
	bool modified;

	void Start (){
		objectToInt = int.Parse (gameObject.name.Substring (5));
	}

	void OnTriggerEnter(Collider col) {
		if (col.name.Contains ("Cube")) {
			colliderLength = col.name.Length;
			colliderName = col.name;
			colliderRealName = colliderName.Substring (4, colliderLength - 4);

			if (colliderRealName == reff [objectToInt] && !modified) {
				distance1++;
				modified = true;
			}
			Debug.Log (distance1);
		}
	}
}
