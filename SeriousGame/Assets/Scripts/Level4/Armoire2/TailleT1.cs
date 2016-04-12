using UnityEngine;
using System.Collections;

public class TailleT1 : MonoBehaviour {

	public static bool valide = false;
	//public GameObject[] jetons;

	void OnTriggerEnter(Collider col){
		if (col.name.Contains ("Nombre")) {
			int taille = int.Parse (col.name.Substring (6,1));
			Debug.Log (taille);
			if (taille == TailleTableau.tailleDuTableau) {
				valide = true;
				Instantiate (col.gameObject, new Vector3 (69.498f - (0.5f * (taille - 1)), 3.14f, -11.659f), Quaternion.identity);
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
}
