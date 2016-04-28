using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SelectMenu : MonoBehaviour {

	int index;

	// Use this for initialization
	void Start () {
		
		index = int.Parse (gameObject.name.Substring (5));
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = Input.mousePosition;
		temp.z = 6.5f;
		GameObject.Find ("curseur").transform.position = Camera.main.ScreenToWorldPoint (temp);
	}

	void OnMouseDown() {
		switch (index) {
		case 0:
			AssignValues (false, false, true);
			break;
		case 1:
			LevelSelector.selector = true;
			LevelSelector.goToLvl = 1;
			Iterations._iteration = 1;
			SceneManager.LoadScene (1);
			break;
		case 2:
			AssignValues (true, false, false);
			break;
		case 3:
			AssignValues (false, true, false);
			break;
		case 4:
			Application.Quit ();
			break;
		default:			
			LevelSelector.selector = true;
			LevelSelector.goToLvl = index - 4;
			Debug.Log (LevelSelector.goToLvl);
			Iterations._iteration = 1;
			SceneManager.LoadScene (1);
			break;
		}
	}

	void AssignValues(bool droite, bool gauche, bool init) {
		StartMenu.rotateD = droite;
		StartMenu.rotateG = gauche;
		StartMenu.reset = init;
	}
}
