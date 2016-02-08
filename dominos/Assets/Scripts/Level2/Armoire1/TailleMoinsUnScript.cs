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
				Instantiate (col.gameObject, new Vector3 (17.18f, 2.1f, -8.2f), Quaternion.identity);
				Destroy(col.gameObject.GetComponent<APorter>());
				Destroy (col.gameObject.GetComponent<Rigidbody> ());
				Destroy (gameObject);
			} else
				valide = false;
		}
		Debug.Log ("n-1 : " + valide);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
