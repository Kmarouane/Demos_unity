using UnityEngine;
using System.Collections;

public class BridgeBuilder : MonoBehaviour {

	public GameObject[] marches;
	public GameObject[] empties;
	Vector3[] destinations;
	Vector3[] departs;
	bool build, built;

	// Use this for initialization
	void Start () {
		departs = new Vector3[15];
		destinations = new Vector3[15];
		for (int i = 0; i < empties.Length; i++) {
			destinations [i] = empties [i].transform.position;
			departs [i] = marches [i].transform.position;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("FPSController").transform.position.z < -13 && !built)
			build = true;

		if (build)
			for (int i = 0; i < marches.Length; i++)
				marches [i].transform.position = Vector3.Slerp (marches [i].transform.position, destinations [i], Time.deltaTime * marches.Length / i);

		if (LevelManager._level == 5) {
			build = false;
			built = true;
			for (int i = 0; i < marches.Length; i++)
				marches [i].transform.position = Vector3.Slerp (marches [i].transform.position, departs [i], Time.deltaTime * (i + 1) / marches.Length);
		}
			
	}
}
