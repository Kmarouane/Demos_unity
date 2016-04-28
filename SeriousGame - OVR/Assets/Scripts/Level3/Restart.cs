using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	public GameObject[] barettes;
	public static int rewind = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (SimuleLevelPrime.canSimulate < 5 && ArmTrig.jetonsPoses == 5)
			GetComponent<Animator> ().SetBool ("mustRewind", true);
		else
			GetComponent<Animator> ().SetBool ("mustRewind", false);
	}

	void OnMouseDown() {
		rewind = 1;
		ArmTrig.jetonsPoses = 0;
		GetComponent<Animator> ().SetBool ("mustRewind", false);
		Invoke ("ResetRewind", (float)(1f / 100f));
	}

	void ResetRewind(){
		rewind = 0;
	}
}
