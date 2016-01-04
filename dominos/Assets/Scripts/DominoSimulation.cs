using UnityEngine;
using System.Collections;

public class DominoSimulation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKeyDown(KeyCode.Space)){
			gameObject.GetComponent<Rigidbody> ().AddForce (0, 0, -10);	
		}
	
	}
}
