using UnityEngine;
using System.Collections;

public class IScript : MonoBehaviour {

	public static bool valide;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.name == "JetonI") {
			valide = true;
			Instantiate (col.gameObject, new Vector3 (20.3f, 2f, -7.9f), Quaternion.identity);
			Destroy(col.gameObject.GetComponent<APorter>());
			Destroy (col.gameObject.GetComponent<Rigidbody> ());
			Destroy (gameObject);
		}
		else
			valide = false;
		
		Debug.Log ("I : " + valide);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
