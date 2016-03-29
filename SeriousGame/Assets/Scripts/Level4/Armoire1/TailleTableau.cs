using UnityEngine;
using System.Collections;

public class TailleTableau : MonoBehaviour {

	public static int tailleDuTableau;

	void OnTriggerEnter(Collider col){
		if (col.name.Contains ("Nombre")) {
			tailleDuTableau = int.Parse (col.name.Substring (6));
			if (tailleDuTableau > 2) {
				Instantiate (col.gameObject, new Vector3 (69.23f, 2.5f, -8.255f), Quaternion.identity);
				Destroy(col.gameObject.GetComponent<APorter>());
				Destroy (col.gameObject.GetComponent<Rigidbody> ());
				Destroy (gameObject);
			}
		} else
			tailleDuTableau = -1;
		Debug.Log ("n : " + tailleDuTableau);
	}
}
