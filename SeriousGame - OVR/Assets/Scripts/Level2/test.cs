using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GameObject.Find ("wolf").GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.O)) {
			if (!anim.GetBool ("isRunning"))
				anim.SetBool ("isRunning", true);
			else
				anim.SetBool ("isRunning", false);
		}
	}
}
