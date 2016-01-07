using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AffichageIteration : MonoBehaviour {

	Text text;
	public Iterations its;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Itération : " + its.getIteration ();
	}
}
