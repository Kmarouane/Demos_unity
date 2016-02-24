using UnityEngine;
using System.Collections;

public class FaceTheCamera : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Camera.main.isActiveAndEnabled == true) {
			transform.LookAt (transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);
			//mainC.GetComponent<Camera> ().enabled = true;
		}
		//if (Camera.main.name!="CameraSimulationLevel2")//.tag == "MainCamera")
	}
}
