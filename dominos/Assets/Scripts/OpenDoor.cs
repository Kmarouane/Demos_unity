﻿using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {

	float angle = 135f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.M)) {
			GoToLvl2 (angle);
		}
	}

	public void GoToLvl2(float a){
		transform.Rotate (Vector3.up, angle , Space.Self);
	}
}