using UnityEngine;
using System.Collections;

public class TailleT1 : MonoBehaviour {

	public static bool valide = false;
	//public GameObject[] jetons;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.name.Contains ("Nombre")) {
			int taille = int.Parse (col.name.Substring (6,1));
			Debug.Log (taille);
			if (taille == TailleTableau.tailleDuTableau) {
				valide = true;
				Instantiate (col.gameObject, new Vector3(16.7f,2.5f,-8.5f), Quaternion.identity);
				Destroy (col.gameObject.GetComponent<APorter> ());
				Destroy (col.gameObject.GetComponent<Rigidbody> ());
				Destroy (gameObject);
			} else
				valide = false;
		}
		else
			valide = false;

		Debug.Log (col.name + " : " + valide);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
