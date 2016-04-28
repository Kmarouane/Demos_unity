using UnityEngine;
using System.Collections;

public class TailleMoinsUnScript : MonoBehaviour {

	public static int tailleMoinsUn;
	public static bool valide = false;

	void OnTriggerEnter(Collider col){
		if (col.name.Contains ("Nombre")) {
			int tmp = int.Parse (col.name.Substring (6));
			if (TailleTableau.tailleDuTableau - tmp == 1) {
				tailleMoinsUn = tmp;
				valide = true;
				Instantiate (col.gameObject, new Vector3 (69.498f - (0.5f * (tailleMoinsUn - 1)), 3.14f, -11.659f), Quaternion.identity);
				Destroy(col.gameObject.GetComponent<APorter>());
				Destroy (col.gameObject.GetComponent<Rigidbody> ());
				Destroy (gameObject);
			} else
				valide = false;
		}
		Debug.Log ("n-1 : " + valide);
	}
}
