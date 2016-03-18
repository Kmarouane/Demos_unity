using UnityEngine;
using System.Collections;

public class LevelWolfSimulation : MonoBehaviour {

	public Rigidbody[] jetons;
	GameObject[] pupitre;
	Vector3[] pos;
	bool can_start = false, levelDone = false;
	int distanceEgalite = 0, distanceY = 0, distanceX = 0;

	// Use this for initialization
	void Start () {
		pos = new Vector3[jetons.Length];
		pupitre = new GameObject[6];
		for (int u = 0; u < pupitre.Length; u++) {
			pupitre [u] = GameObject.Find ("nrg" + (u + 1));
			Debug.Log (pupitre [u].name);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (LevelManager._level == 2) {
			for (int i = 0; i < jetons.Length; i++)
				pos [i] = jetons [i].transform.position;

			for (int i = 0; i < jetons.Length; i++) {
				if (i < 3) {
					if (pos [i].y == pos [i + 1].y)
						distanceEgalite++;			
				} else if (i >= 3 && i < jetons.Length - 1) {
					if (pos [i].y > pos [i + 1].y)
						distanceY++;
				}
				if (pos [i].x > 29.633 && pos [i].x < 30.278)
					distanceX++;
			}
			//Debug.Log (distanceY + " , " + distanceX);
			if (distanceEgalite == 3 && distanceY == 5 && distanceX == 9) {
				can_start = true;
				GetComponent<Animator> ().enabled = true;
			} else {
				can_start = false;
				GetComponent<Animator> ().enabled = false;
			}
			distanceEgalite = 0;
			distanceY = 0;
			distanceX = 0;
		}
	}

	IEnumerator OnMouseDown() {
		if (can_start && !levelDone) {
			GameObject.Find ("wolf").GetComponent<Animator> ().SetBool ("isRunning", true);
			for(int i=0;i<pupitre.Length;i++){
				pupitre [i].GetComponent<Renderer> ().material.color = Color.red;
				yield return new WaitForSeconds (3.0f);
			}
			GameObject.Find ("wolf").GetComponent<Animator> ().SetBool ("isRunning", false);
			GameObject.Find ("porte_de_fer").transform.position = new Vector3 (30, 11, 0);
			levelDone = true;
			Destroy (gameObject);
		}
	}
}
