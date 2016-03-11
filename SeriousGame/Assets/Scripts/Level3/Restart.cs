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
		
	}

	void OnMouseDown() {
		rewind = 1;
		Invoke ("ResetRewind", (float)(1f / 100f));
	}

	void ResetRewind(){
		rewind = 0;
	}
}
