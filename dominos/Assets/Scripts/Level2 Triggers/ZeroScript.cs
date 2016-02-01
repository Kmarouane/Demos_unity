using UnityEngine;
using System.Collections;

public class ZeroScript : MonoBehaviour {

	public static bool vide;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.name == "Nombre0")
			vide = true;
		else
			vide = false;
		Debug.Log ("0 : " + vide);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
