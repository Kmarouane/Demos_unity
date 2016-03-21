using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Level2Transition : MonoBehaviour {

	public Camera mainC;
	public Camera simuLvl2C;
	public Camera openDoorC;
	public GameObject pivot;
	int closeTheDoor = 0;
	int doorClosed = 0;

	// Use this for initialization
	void Start () {
		openDoorC.GetComponent<Camera>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (LevelManager._level == 2) {
			
			if (closeTheDoor == 1 && doorClosed == 0){
				pivot.gameObject.GetComponent<Animator> ().enabled = true;
				pivot.gameObject.GetComponent<Animator> ().Play ("FermetureDePorte", -1, 0f);
				doorClosed = 1;
			}
		}

	}

	IEnumerator OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Domino5") {
			LevelManager.levelCompleted = true;
			yield return new WaitForSeconds (1.50f);
			FaceTheCamera.followCamera = false;
			openDoorC.GetComponent<Camera>().enabled = true;
			mainC.GetComponent<Camera> ().enabled = false;
			simuLvl2C.GetComponent<Camera> ().enabled = false;
			yield return new WaitForSeconds (0.50f);
			pivot.gameObject.GetComponent<Animator> ().enabled = true;
			yield return new WaitForSeconds (3.30f);
			pivot.gameObject.GetComponent<Animator> ().enabled = false;
			yield return new WaitForSeconds (0.50f);
			openDoorC.GetComponent<Camera>().enabled = false;
			mainC.GetComponent<Camera> ().enabled = true;
			FaceTheCamera.followCamera = true;
			closeTheDoor = 1;
		}
	}

}
