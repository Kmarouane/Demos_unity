using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Level2Transition : MonoBehaviour {

	GameObject porte;
	GameObject joueur;
	GameObject ac;

	public OpenDoor openLevel2Door;

	// Use this for initialization
	void Start () {
		porte = GameObject.Find ("PivotPorte");
		joueur = GameObject.Find ("FPSController");
		ac = GameObject.Find ("AchivementImage");
		ac.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Mathf.Ceil(joueur.transform.position.x) >= Mathf.Ceil(porte.transform.position.x)) {
			LevelManager._level = 2;
		}

	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Domino5") {
			openLevel2Door.GoToLvl2 (135f);
			Invoke ("FinNiveau", 0f);
			Invoke ("FinNiveau", 3f);
		}
	}

	void FinNiveau(){
		if(!ac.activeSelf)
			ac.SetActive (true);
		else
			ac.SetActive (false);
	}
}
