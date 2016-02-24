using UnityEngine;
using System.Collections;

public class InitLevel2 : MonoBehaviour {

	int can_instantiate = 0;
	public Material red_color;
	bool can_click = false;
	public static int taille;   //s'il y a une erreur enleve public
	bool kinematic_state;
	Color[] colors = new Color[3];

	public static GameObject[] dominos;
	GameObject[] fleches;
	//public Vector3[] positions;

	public GameObject domino;
	public GameObject arrow;
	public GameObject ouvrirArmoire2;
	public GameObject armoire2Text1;
	public GameObject armoire2Text2;

	public static int niveauInitialise = 0;

	// Use this for initialization

	void OnMouseDown(){
		if (can_click) {
			can_click = false;
			gameObject.GetComponent<Renderer> ().material.color = red_color.color;

			dominos = new GameObject[taille];
			//positions = new Vector3[taille];
			fleches = new GameObject[taille];

			can_instantiate = 1;
		}
	}

	//Placer les dominos à l'intérieur du cylindre
	void InstantiateDomino(){
		//for (int i = 0; i < taille; i++) {
			//Instantiate (domino, new Vector3 (14.86f, 1.229f, (float)Random.Range (1.89f, 8.05f)), Quaternion.identity);
		//}
		Iterations._iteration = 1;

		switch(taille){
		case 3:
			dominos [0] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 5.12f), Quaternion.identity) as GameObject;
			dominos [1] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 4.2f), Quaternion.identity) as GameObject;
			dominos [2] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 3.282f), Quaternion.identity) as GameObject;
			break;
		case 4:
			dominos [0] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 5.124f), Quaternion.identity) as GameObject;
			dominos [1] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 4.2f), Quaternion.identity) as GameObject;
			dominos [2] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 3.282f), Quaternion.identity) as GameObject;
			dominos [3] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 2.307f), Quaternion.identity) as GameObject;
			break;
		case 5:
			dominos [0] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 5.72f), Quaternion.identity) as GameObject;
			dominos [1] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 4.8f), Quaternion.identity) as GameObject;
			dominos [2] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 3.88f), Quaternion.identity) as GameObject;
			dominos [3] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 2.91f), Quaternion.identity) as GameObject;
			dominos [4] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 1.96f), Quaternion.identity) as GameObject;
			break;
		case 6:
			dominos [0] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 6.29f), Quaternion.identity) as GameObject;
			dominos [1] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 5.37f), Quaternion.identity) as GameObject;
			dominos [2] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 4.45f), Quaternion.identity) as GameObject;
			dominos [3] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 3.48f), Quaternion.identity) as GameObject;
			dominos [4] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 2.53f), Quaternion.identity) as GameObject;
			dominos [5] = Instantiate (domino, new Vector3 (15.219f, 1.494f, 1.64f), Quaternion.identity) as GameObject;
			break;
		}
		ChangeKinematicState ();
		PaintDominos ();
		InvertDominos ();
		ShowArrows ();
		niveauInitialise += 1;
		ouvrirArmoire2.gameObject.GetComponent<Animator> ().enabled = true;
		armoire2Text1.gameObject.GetComponent<Renderer> ().enabled = true;
		armoire2Text2.gameObject.GetComponent<Renderer> ().enabled = true;
	}

	void ChangeKinematicState(){
		for (int i = 0; i < taille; i++) {
			dominos [i].gameObject.GetComponent<Rigidbody> ().isKinematic = kinematic_state;
		}
	}

	void PaintDominos(){
		for (int i = 0; i < taille; i++) {
			dominos [i].gameObject.GetComponent<Renderer> ().material.color = colors [i % 3];
		}
	}

	void InvertDominos(){
		for (int i = 0; i < taille; i++) {
			if (i % 2 == 1)
				dominos [i].transform.Rotate (Vector3.up * 90f);
			else
				dominos [i].transform.Rotate (-Vector3.up * 90f);
		}
	}

	void ShowArrows(){
		for (int i = 0; i < taille; i++) {
			fleches [i] = Instantiate (arrow, dominos [i].transform.position, dominos [i].transform.rotation) as GameObject;
		}
	}
	// Update is called once per frame
	void Update () {
		if (!can_click &&
			TailleTableau.tailleDuTableau > 0 &&
		    ForScript.valide && IScript.valide && ZeroScript.vide && TailleMoinsUnScript.valide &&
			BoolScript.valide && BoolScript.value &&
		    Color1Script.changed && Color2Script.changed && Color3Script.changed) {

			taille = TailleTableau.tailleDuTableau;
			kinematic_state = BoolScript.value;
			colors [0] = Color1Script.color;
			colors [1] = Color2Script.color;
			colors [2] = Color3Script.color;

			can_click = true;

		}

		if (can_instantiate == 1 && niveauInitialise == 0) {
			InstantiateDomino ();
			can_instantiate = 0;
		}

		if (niveauInitialise == 1)
			for (int i = 0; i < taille; i++)
				fleches [i].transform.rotation = dominos [i].transform.rotation;
	}
}
