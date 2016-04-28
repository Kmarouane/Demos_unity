using UnityEngine;
using System.Collections;

public class DynamicScale : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3 (0.5f, 0.5f, 0.4f);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.localScale.x < 0.995)
			transform.localScale += new Vector3 (0.005f, 0.005f, 0.005f);
	}
}
