using UnityEngine;
using System.Collections;

public class Level2Transition : MonoBehaviour {

	public OpenDoor openLevel2Door;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Domino5")
			openLevel2Door.Level2Transition ();
	}
}
