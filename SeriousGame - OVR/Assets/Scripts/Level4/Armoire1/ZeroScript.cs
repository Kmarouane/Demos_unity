using UnityEngine;
using System.Collections;

public class ZeroScript : MonoBehaviour {

	public static bool vide;

	void OnTriggerEnter(Collider col){
		if (col.name == "Nombre0") {
			vide = true;
			Instantiate (col.gameObject, new Vector3 (69.498f, 3.14f, -11.659f), Quaternion.identity);
			Destroy(col.gameObject.GetComponent<APorter>());
			Destroy (col.gameObject.GetComponent<Rigidbody> ());
			Destroy (gameObject);
		}
		else
			vide = false;
		
		Debug.Log ("0 : " + vide);
	}
}
