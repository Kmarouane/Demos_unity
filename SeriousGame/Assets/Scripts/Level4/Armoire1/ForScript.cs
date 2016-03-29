using UnityEngine;
using System.Collections;

public class ForScript : MonoBehaviour {

	public static bool valide = false;

	void OnTriggerEnter(Collider col){
		if (col.name == "JetonFOR") {
			valide = true;
			Instantiate (col.gameObject, new Vector3 (78.41f, 2.2f, -6.27f), Quaternion.identity);
			Destroy(col.gameObject.GetComponent<APorter>());
			Destroy (col.gameObject.GetComponent<Rigidbody> ());
			Destroy (gameObject);
		}
		else
			valide = false;
		
		Debug.Log ("For : " + valide);
	}
}
