using UnityEngine;
using System.Collections;

public class Color2Script : MonoBehaviour {

	// Use this for initialization

	public static Color color;
	public static bool changed = false;

	// Use this for initialization

	void OnTriggerEnter(Collider col){
		if (col.name.Contains ("Couleur")){
			color = col.gameObject.GetComponent<Renderer> ().material.color;
			changed = true;
		} else
			changed = false;
		Debug.Log (changed);
	}
}
