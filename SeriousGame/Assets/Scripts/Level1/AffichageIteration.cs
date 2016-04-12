using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AffichageIteration : MonoBehaviour {

	Text text;
	TextMesh vr_text;
	//public Iterations its;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		vr_text = GameObject.Find ("VR_TextIteration").gameObject.GetComponent<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (LevelManager._level != 2)
			text.text = "Itération : " + Iterations._iteration;
		else
			text.text = "";
		vr_text.text = text.text;
	}
}
