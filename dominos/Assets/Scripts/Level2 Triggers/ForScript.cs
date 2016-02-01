using UnityEngine;
using System.Collections;

public class ForScript : MonoBehaviour {

	public static bool valide = false;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.name == "JetonFOR")
			valide = true;
		else
			valide = false;
		
		Debug.Log ("For : " + valide);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
