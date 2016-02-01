using UnityEngine;
using System.Collections;

public class IScript : MonoBehaviour {

	public static bool valide;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.name == "JetonI")
			valide = true;
		else
			valide = false;
		Debug.Log ("I : " + valide);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
