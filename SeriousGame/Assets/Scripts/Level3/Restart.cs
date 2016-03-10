using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	public GameObject[] barettes;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		Destroy (gameObject);
		/*
		for (int u = 0; u < barettes.Length; u++) {
			DestroyImmediate (barettes [u], true);
			//Destroy (barettes [u].gameObject);
			ArmTrig.done = false;
		}*/
	}
}
