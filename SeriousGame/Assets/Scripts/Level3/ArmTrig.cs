using UnityEngine;
using System.Collections;

public class ArmTrig : MonoBehaviour {

	public GameObject goodCube;
	public GameObject[] barettes;
	//public GameObject barette;
	Vector3 pos;
	GameObject clone, tmpJeton;
	bool done = false;
	int index;
	public static int jetonsPoses = 0;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.name.Contains ("LevelPrimeJeton")) {
			if (!done) {
				index = int.Parse (col.name.Substring (15, 1));
				if (index < 5 && Manager.distances [index] == 0) {
					jetonsPoses++;
					pos = new Vector3 (52.99f, transform.position.y, 6.3f);
					Invoke	("SpawnBarette", 1f);
					tmpJeton = col.gameObject;
					Manager.distances [index] = 1;
					if (col.name == goodCube.name)
						SimuleLevelPrime.canSimulate++;

					done = true;
				}
			}
		}
	}
	/*
	void OnTriggerStay(Collider other) {
		if (other.attachedRigidbody && Restart.rewind == 1)
			other.attachedRigidbody.AddForce (Vector3.up * 10);
	}
*/
	void SpawnBarette(){
		clone = Instantiate (barettes[index], pos, Quaternion.identity) as GameObject;
	}

	void Update(){
		if (Restart.rewind == 1 && done) {			
			Destroy (clone.gameObject);
			done = false;
			SimuleLevelPrime.canSimulate = 0;
			for (int u = 0; u < 5; u++) 
				Manager.distances [u] = 0;
			tmpJeton.transform.position = new Vector3 (GameObject.Find ("plateformeJeton" + index).transform.position.x, 2, GameObject.Find ("plateformeJeton" + index).transform.position.z);
			//Instantiate (goodCube, new Vector3 (), Quaternion.identity);
		}
	}
}
