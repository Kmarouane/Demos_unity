using UnityEngine;
using System.Collections;

public class ArmoireVT1 : MonoBehaviour {

	public GameObject tiroirTantQue;
	public GameObject jeton;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider col){
		if (InitLevel2.niveauInitialise == 0) {
			if (col.name == "JetonTantQue") {
				Instantiate (tiroirTantQue,tiroirTantQue.transform.position,Quaternion.identity);
				//Instantiate (jeton, new Vector3 (21.83f, 2.133f, -7.07f), Quaternion.identity);
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
