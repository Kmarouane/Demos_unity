using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public static int _level = 1;
	Text text;
	TextMesh vr_text;
	public static bool levelCompleted = false;
	GameObject finNiveau, joueur;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		vr_text = GameObject.Find ("VR_TextLevel").gameObject.GetComponent<TextMesh> ();
		finNiveau = GameObject.Find ("NiveauTerminé");
		finNiveau.SetActive (false);
		joueur = GameObject.Find ("FPSController");
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Level : " + _level;
		vr_text.text = "Level : " + _level;
		if (joueur.transform.position.x >= 10 && joueur.transform.position.x < 31 && joueur.transform.position.z > -47)
			_level = 2;
		else if (joueur.transform.position.x >= 31 && joueur.transform.position.x < 63 && joueur.transform.position.z > -47)
			_level = 3;
		else if (joueur.transform.position.x >= 63 && joueur.transform.position.z > -47)
			_level = 4;
		else if (joueur.transform.position.z < -50)
			_level = 5;
		else
			_level = 1;

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
