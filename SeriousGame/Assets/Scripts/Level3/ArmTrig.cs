using UnityEngine;
using System.Collections;

public class ArmTrig : MonoBehaviour {

	public GameObject goodCube;
	public GameObject barette;
	Vector3 pos;
	public static bool done = false;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.name == goodCube.name) {
			if (!done) {
				pos = new Vector3 (50.1f, transform.position.y, 9.8f);
				Invoke	("SpawnBarette", 1f);
				SimuleLevelPrime.canSimulate++;
				done = true;
			}
		}
	}

	void SpawnBarette(){
		Instantiate (barette, pos, Quaternion.identity);
	}
}
