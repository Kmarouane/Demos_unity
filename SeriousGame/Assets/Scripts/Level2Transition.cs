using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Level2Transition : MonoBehaviour {

	GameObject porte;
	GameObject joueur;
	GameObject ac;

	public Camera mainC;
	public Camera simuLvl2C;
	public Camera openDoorC;
	public GameObject pivot;
	int closeTheDoor = 0;
	int doorClosed = 0;

	// Use this for initialization
	void Start () {
		porte = GameObject.Find ("PivotPorte");
		joueur = GameObject.Find ("FPSController");
		ac = GameObject.Find ("AchivementImage");
		ac.SetActive (false);
		openDoorC.GetComponent<Camera>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Mathf.Ceil(joueur.transform.position.x) >= Mathf.Ceil(porte.transform.position.x)) {
			LevelManager._level = 2;
			if (closeTheDoor == 1 && doorClosed == 0){
				pivot.gameObject.GetComponent<Animator> ().enabled = true;
				pivot.gameObject.GetComponent<Animator> ().Play ("FermetureDePorte", -1, 0f);
				doorClosed = 1;
			}
		}

	}

	IEnumerator OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Domino5") {
			Invoke ("FinNiveau", 0f);
			Invoke ("FinNiveau", 3f);

			openDoorC.GetComponent<Camera>().enabled = true;
			mainC.GetComponent<Camera> ().enabled = false;
			simuLvl2C.GetComponent<Camera> ().enabled = false;
			pivot.gameObject.GetComponent<Animator> ().enabled = true;
			yield return new WaitForSeconds (3.30f);
			pivot.gameObject.GetComponent<Animator> ().enabled = false;
			openDoorC.GetComponent<Camera>().enabled = false;
			mainC.GetComponent<Camera> ().enabled = true;
			closeTheDoor = 1;
		}
	}

	void FinNiveau(){
		if(!ac.activeSelf)
			ac.SetActive (true);
		else
			ac.SetActive (false);
	}
}
