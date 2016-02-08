using UnityEngine;
using System.Collections;

public class Assenceur : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerStay(Collider col){
		if (col.gameObject.name == "FPSController") {
			Debug.Log ("player");
			if (Input.GetKeyDown(KeyCode.A)) {
				Debug.Log ("appui sur a");
				
			}
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
