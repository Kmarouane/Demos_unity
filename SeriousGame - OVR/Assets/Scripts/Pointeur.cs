using UnityEngine;
using System.Collections;

public class Pointeur : MonoBehaviour {

	Vector3 temp;

	// Use this for initialization
	void Start () {
		temp = Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update () {
		if (FaceTheCamera.followCamera) {
			temp = Input.mousePosition;
			temp.z = 3.2f;
			transform.position = Camera.main.ScreenToWorldPoint (temp);
		}
	}
}
