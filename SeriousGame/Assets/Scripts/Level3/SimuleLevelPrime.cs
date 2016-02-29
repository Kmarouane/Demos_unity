using UnityEngine;
using System.Collections;

public class SimuleLevelPrime : MonoBehaviour {

	public static bool clicked ;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("clicked " + clicked);
	}

	void OnMouseDown(){
		clicked = true;
		Debug.Log ("clicked " + clicked);
	}
}
