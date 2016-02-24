using UnityEngine;
using System.Collections;

public class ZeroScript : MonoBehaviour {

	public static bool vide;

	void OnTriggerEnter(Collider col){
		if (col.name == "Nombre0") {
			vide = true;
			Instantiate (col.gameObject, new Vector3 (17.18f, 2.133f, -8.25f), Quaternion.identity);
			Destroy(col.gameObject.GetComponent<APorter>());
			Destroy (col.gameObject.GetComponent<Rigidbody> ());
			Destroy (gameObject);
		}
		else
			vide = false;
		
		Debug.Log ("0 : " + vide);
	}
}
