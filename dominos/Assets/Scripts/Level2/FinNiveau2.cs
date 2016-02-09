using UnityEngine;
using System.Collections;

public class FinNiveau2 : MonoBehaviour {

	public InitLevel2 scriptInit;
	GameObject ac;

	// Use this for initialization
	void Start () {
		ac = GameObject.Find ("AchivementImage");
		ac.SetActive (false);
	}

	void OnTriggerEnter(Collider col){
		if (col == scriptInit.dominos [scriptInit.taille - 1]) {
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
