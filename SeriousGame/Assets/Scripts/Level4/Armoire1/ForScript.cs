using UnityEngine;
using System.Collections;

public class ForScript : MonoBehaviour {

	public static bool valide = false;

	void OnTriggerEnter(Collider col){
		if (col.name == "JetonFOR") {
			valide = true;
			Instantiate (col.gameObject, new Vector3 (79.404f, 1.434f, -6.905f), Quaternion.identity);
			Destroy(col.gameObject.GetComponent<APorter>());
			Destroy (col.gameObject.GetComponent<Rigidbody> ());
			Destroy (gameObject);
		}
		else
			valide = false;
		
		Debug.Log ("For : " + valide);
	}
}
