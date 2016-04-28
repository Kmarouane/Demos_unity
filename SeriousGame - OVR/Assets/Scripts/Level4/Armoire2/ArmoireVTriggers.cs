using UnityEngine;
using System.Collections;

public class ArmoireVTriggers : MonoBehaviour {

	public static bool valide = false;
	public GameObject jeton;

	void OnTriggerEnter(Collider col){
		if (col.name.Contains(jeton.name)) {
			valide = true;
			SimulLevel2.verificateurs++;
			Instantiate (col.gameObject, jeton.transform.position, Quaternion.identity);
			Destroy(col.gameObject.GetComponent<APorter>());
			Destroy (col.gameObject.GetComponent<Rigidbody> ());
			Destroy (gameObject);
		}
		else
			valide = false;

		Debug.Log (jeton.name + " : " + valide);
	}
}
