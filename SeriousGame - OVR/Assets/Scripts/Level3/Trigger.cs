using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {
	/*
	public GameObject[] barette;
	int index, currentBarette;
	int[] checks = { 0, 0, 0, 0, 0 };
	Vector3 pos;
	int verif = 0;

	void OnTriggerEnter(Collider col){
		if (col.name.Contains ("LevelPrimeJeton")) {			
			index = int.Parse (col.name.Substring (15, 1));

			pos = new Vector3 (50.1f, col.transform.position.y, 9.8f);
			if (checks [index] == 0) {
				if (index == 0) {
					barette [0].GetComponentInChildren<TextMesh> ().text = "POUR i <---- de 0 à " + (Ingurgiteur.nbDominos - 1);
				}
				col.transform.position = new Vector3 (55.15f, 0.31f, 8.94f);//48.66817 4.737207 9.832153
				//col.GetComponent<Rigidbody> ().isKinematic = true;  		// armoire : 50.10646 1.971728 9.978553
				Invoke	("SpawnSolution", 1f);
				checks [index] = 1;
			}

		}
	}


	void SpawnSolution(){
		Instantiate (barette [index], pos, Quaternion.identity);
	}*/
}
