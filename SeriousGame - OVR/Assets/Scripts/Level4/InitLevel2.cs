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
		for (int i = 0; i < taille; i++) {
			dominos [i] = Instantiate (domino, new Vector3 (76.05f, 2.5f, 11.5f - i), Quaternion.identity) as GameObject;
		}
		Iterations._iteration = 0;
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
		/*if (LevelManager._level == 4)
			GameObject.Find ("Directional Light").SetActive (false);
		else
			GameObject.Find ("Directional Light").SetActive (true);*/
		
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
			GetComponent<Animator> ().SetBool ("blink", true);

		}

		if (can_instantiate == 1 && niveauInitialise == 0) {
			GetComponent<Animator> ().SetBool ("blink", false);
			GetComponent<Animator> ().enabled = false;
			InstantiateDomino ();
			can_instantiate = 0;
		}

		if (niveauInitialise == 1)
			for (int i = 0; i < taille; i++)
				fleches [i].transform.rotation = dominos [i].transform.rotation;
	}
}
