using UnityEngine;
using System.Collections;

public class IScript : MonoBehaviour {

	public static bool valide;

	void OnTriggerEnter(Collider col){
		if (col.name == "JetonI") {
			valide = true;
			Instantiate (col.gameObject, new Vector3 (78.785f, 2.133f, -7.11f), Quaternion.identity);
			Destroy(col.gameObject.GetComponent<APorter>());
			Destroy (col.gameObject.GetComponent<Rigidbody> ());
			Destroy (gameObject);
		}
		else
			valide = false;
		
		Debug.Log ("I : " + valide);
	}
}
