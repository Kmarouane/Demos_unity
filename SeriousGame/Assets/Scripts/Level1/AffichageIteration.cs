using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AffichageIteration : MonoBehaviour {

	Text text;
	//public Iterations its;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (LevelManager._level != 2)
			text.text = "Itération : " + Iterations._iteration;
		else
			text.text = "";
	}
}
