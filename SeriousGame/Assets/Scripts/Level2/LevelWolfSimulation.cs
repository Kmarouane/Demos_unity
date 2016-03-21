using UnityEngine;
using System.Collections;

public class LevelWolfSimulation : MonoBehaviour {

	public Rigidbody[] jetons;
	GameObject[] pupitre;
	Vector3[] pos;
	bool can_start = false, levelDone = false;
	int distanceEgalite = 0, distanceY = 0, distanceX = 0, distanceRestes = 0;
	Vector3 elec, charge;

	// Use this for initialization
	void Start () {
		pos = new Vector3[jetons.Length];
		pupitre = new GameObject[6];
		for (int u = 0; u < pupitre.Length; u++)
			pupitre [u] = GameObject.Find ("nrg" + (u + 1));
		
	}
	
	// Update is called once per frame
	void Update () {
		if (LevelManager._level == 2) {
			elec = GameObject.Find ("TantQueJetonNRG (1)").transform.position;
			charge = GameObject.Find ("TantQueJetonCHARGE (1)").transform.position;
			for (int i = 0; i < jetons.Length; i++)
				pos [i] = jetons [i].transform.position;

			for (int i = 0; i < jetons.Length; i++) {
				if (i < 3) {
					if (pos [i].y == pos [i + 1].y && pos [i].z > pos [i + 1].z)
						distanceEgalite++;
				} else if (i >= 3 && i < jetons.Length - 1) {
					if (pos [i].y > pos [i + 1].y)
						distanceY++;
				}
				if (pos [i].x > 29.633 && pos [i].x < 30.278)
					distanceX++;
			}
			if (elec.y == charge.y && charge.y == pos [6].y && charge.x > 29.633 && elec.x > 29.633 && elec.z > charge.z)
				distanceRestes++;
			//Debug.Log (elec.x+","+elec.y + " ; " + charge.x+","+charge.y);
			if (distanceEgalite == 3 && distanceY == 5 && distanceX == 9 && distanceRestes == 1) {
				can_start = true;
				GetComponent<Animator> ().enabled = true;
			} else {
				can_start = false;
				GetComponent<Animator> ().enabled = false;
			}
			distanceEgalite = 0;
			distanceY = 0;
			distanceX = 0;
			distanceRestes = 0;
		} else if (LevelManager._level == 3) {
			GameObject.Find ("porte_de_fer").transform.position = Vector3.Slerp (GameObject.Find ("porte_de_fer").transform.position, new Vector3 (GameObject.Find ("porte_de_fer").transform.position.x, -5.75f, GameObject.Find ("porte_de_fer").transform.position.z), 2f * Time.deltaTime);
		}
	}

	IEnumerator OnMouseDown() {
		if (can_start && !levelDone) {
			GetComponent<Animator> ().Play ("DesactivationBouton");
			GameObject.Find ("wolf").GetComponent<Animator> ().SetBool ("isRunning", true);
			for (int i = 0; i < pupitre.Length; i++) {
				yield return new WaitForSeconds (3.0f);
				pupitre [i].GetComponent<Renderer> ().material.color = Color.red;
			}

			while (GameObject.Find ("porte_de_fer").transform.position.y < 11) {
				GameObject.Find ("porte_de_fer").transform.position = Vector3.MoveTowards (GameObject.Find ("porte_de_fer").transform.position, new Vector3 (30, 11, 0), 2.0f * Time.fixedDeltaTime);
				yield return new WaitForSeconds (0.05f);
			}
			GameObject.Find ("wolf").GetComponent<Animator> ().SetBool ("isRunning", false);
			levelDone = true;
			LevelManager.levelCompleted = true;
			Destroy (gameObject);
		}
	}
}
