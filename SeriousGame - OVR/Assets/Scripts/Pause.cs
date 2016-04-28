using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class Pause : MonoBehaviour {

	bool pause, afficherMenu;
	GameObject menu;

	// Use this for initialization
	void Start () {
		menu = GameObject.Find ("PausePlane");
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (Input.GetKeyDown (KeyCode.N)) {
			Screen.lockCursor = false;
			SceneManager.LoadScene (0);
		}
		*/
		if (Input.GetKeyDown (KeyCode.C))
			pause = !pause;
		
		if (pause) {
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				Screen.lockCursor = false;
				SceneManager.LoadScene (0);
				pause = false;
			}
			//Time.timeScale = 0;
			GameObject.Find ("FPSController").GetComponent<FirstPersonController> ().enabled = false;
			afficherMenu = true;
		} else {
			//Time.timeScale = 1;
			GameObject.Find ("FPSController").GetComponent<FirstPersonController> ().enabled = true;
			afficherMenu = false;
		}

		if (!afficherMenu)
			menu.SetActive (false);
		else
			menu.SetActive (true);
	}
}
