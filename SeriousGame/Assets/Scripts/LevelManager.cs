using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public static int _level = 1;
	Text text;
	public static bool levelCompleted = false;
	GameObject finNiveau, joueur;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		finNiveau = GameObject.Find ("AchivementImage");
		finNiveau.SetActive (false);
		joueur = GameObject.Find ("FPSController");
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Level : " + _level;
		if (joueur.transform.position.x >= 10 && joueur.transform.position.x < 31)
			_level = 2;
		else if (joueur.transform.position.x >= 31 && joueur.transform.position.x < 63)
			_level = 3;
		else if (joueur.transform.position.x >= 63)
			_level = 4;

		if (levelCompleted) {
			Invoke ("FinNiveau", 0f);
			Invoke ("FinNiveau", 5f);
			levelCompleted = false;
		}			
	}

	void FinNiveau(){
		if(!finNiveau.activeSelf)
			finNiveau.SetActive (true);
		else
			finNiveau.SetActive (false);
	}

}
