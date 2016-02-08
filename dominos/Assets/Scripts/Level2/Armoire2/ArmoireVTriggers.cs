using UnityEngine;
using System.Collections;

public class ArmoireVTriggers : MonoBehaviour {

	public static bool valide = false;
	public GameObject jeton;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.name == jeton.name) {
			valide = true;
			Instantiate (col.gameObject, jeton.transform.position/*new Vector3 (21.83f, 2.133f, -7.07f)*/, Quaternion.identity);
			Destroy(col.gameObject.GetComponent<APorter>());
			Destroy (col.gameObject.GetComponent<Rigidbody> ());
			Destroy (gameObject);
		}
		else
			valide = false;

		Debug.Log (jeton.name + " : " + valide);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
