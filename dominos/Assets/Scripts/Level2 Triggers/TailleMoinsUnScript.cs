using UnityEngine;
using System.Collections;

public class TailleMoinsUnScript : MonoBehaviour {

	public static int tailleMoinsUn;
	public static bool valide = false;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.name.Contains ("Nombre")) {
			int tmp = int.Parse (col.name.Substring (6));
			if (TailleTableau.tailleDuTableau - tmp == 1) {
				tailleMoinsUn = tmp;
				valide = true;
			} else
				valide = false;
		}
		Debug.Log ("n-1 : " + valide);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
