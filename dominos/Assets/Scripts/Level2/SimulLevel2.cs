using UnityEngine;
using System.Collections;

public class SimulLevel2 : MonoBehaviour {

	bool can_click = false;
	public Material black_color;
	public static int verificateurs = 0;

	public InitLevel2 scriptInit;

	// Use this for initialization
	void Start () {
		
	}

	void OnMouseDown(){
		if (can_click) {
			can_click = false;
			gameObject.GetComponent<Renderer> ().material.color = black_color.color;

			for (int i = 0; i < TailleTableau.tailleDuTableau; i++) {
				if (i % 2 == 1) 
					scriptInit.dominos [i].transform.Rotate (-Vector3.up * 90f);
				else
					scriptInit.dominos [i].transform.Rotate (Vector3.up * 90f);
			}
			for (int i = 0; i < TailleTableau.tailleDuTableau; i++) {
				scriptInit.dominos [i].GetComponent<Rigidbody> ().isKinematic = false;
				if (i == 0)
					scriptInit.dominos [i].GetComponent<Rigidbody> ().AddForce (0, 0, -10);
					
			}
		}
	}

	// Update is called once per frame
	void Update () {
		Debug.Log ("Peut appuyer? : " + can_click + " why " + verificateurs);
		if (!can_click &&
		    TailleT1.valide && TailleMoinsUnT1.valide && verificateurs == 14 && InitLevel2.niveauInitialise == 1)
			can_click = true;

	}
}
