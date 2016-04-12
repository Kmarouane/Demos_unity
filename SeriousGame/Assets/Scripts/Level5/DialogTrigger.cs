using UnityEngine;
using System.Collections;

public class DialogTrigger : MonoBehaviour {

	public GameObject character;
	public static bool isNear = false;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter (Collider col) {
		if (col.name == character.name)
			isNear = true;
		Invoke ("ResetBool", 0.5f);
	}

	void ResetBool () {
		isNear = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
