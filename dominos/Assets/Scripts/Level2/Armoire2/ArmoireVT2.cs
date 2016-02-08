using UnityEngine;
using System.Collections;

public class ArmoireVT2 : MonoBehaviour {

	public GameObject tiroirPour;
	public GameObject jeton;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider col){
		if (InitLevel2.niveauInitialise == 0) {
			if (col.name == "JetonFOR") {
				Instantiate (tiroirPour,tiroirPour.transform.position,Quaternion.identity);
				//Instantiate (jeton, new Vector3 (20.568f, 2.133f, -6.975f), Quaternion.identity);
				//Destroy(col.gameObject.GetComponent<APorter>());
				//Destroy (col.gameObject.GetComponent<Rigidbody> ());
				Destroy (gameObject);
				//Destroy(col);
			}
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
