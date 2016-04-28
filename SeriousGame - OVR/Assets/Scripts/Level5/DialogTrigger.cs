using UnityEngine;
using System.Collections;

public class DialogTrigger : MonoBehaviour {

	public GameObject character;
	public static bool isNear;

	// Use this for initialization

	void OnTriggerEnter (Collider col) {
		if (col.name == character.name)
			isNear = true;
		Invoke ("ResetBool", 0.5f);
	}

	void ResetBool () {
		isNear = false;
	}

}
