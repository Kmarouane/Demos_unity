using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	GameObject[] dominosTableau;
	public GameObject canonACouleurs;
	public GameObject nuageAFoudre;
	GameObject objetDomino;
	GameObject canon;
	GameObject nuage;
	public GameObject objetDominoGris;
	public GameObject objetDominoNoir;
	public Transform rotationTarget;
	public ParticleSystem cloudParticles;

	int taille = 9, currentDomino, cheksum = 0;
	bool canNuage = true, canCanon = true;
	float x, y, z;
	Vector3 spawnPosition;

	// Use this for initialization
	void Start () {
		dominosTableau = new GameObject[taille];
		spawnPosition = new Vector3 (50.10654f, 2.48f, 9.99f);
	}
	
	// Update is called once per frame
	void Update () {
		if (currentDomino % 2 == 1)
			objetDomino = objetDominoNoir;
		else
			objetDomino = objetDominoGris;
		
		currentDomino = Ingurgiteur.nbDominos;
		Debug.Log (currentDomino);
		if (Ingurgiteur.index == 5) {
			if (currentDomino > 0 && currentDomino < 10 && Ingurgiteur.canInstantiateDomino) {
				dominosTableau [currentDomino - 1] = Instantiate (objetDomino, new Vector3 (42.95f - (currentDomino - 1), 1.008f, 9.97f), Quaternion.RotateTowards (objetDomino.transform.rotation, rotationTarget.rotation, 15.0f)) as GameObject;
				cloudParticles.Play ();
				cloudParticles.startLifetime = cloudParticles.startLifetime;
				cloudParticles.transform.Translate (Vector3.left);
				Ingurgiteur.canInstantiateDomino = false;
				if (currentDomino == 9)
					cheksum++;
			}
		} else if (Ingurgiteur.index == 4) {
			if (canNuage) {
				nuage = Instantiate (nuageAFoudre, spawnPosition, Quaternion.identity) as GameObject;
				cheksum++;
				canNuage = false;
				x = 42.95f; y = 5.0f; z = 9.95f;
				Invoke ("MoveNuageAfter", 1.0f);
			}
		} else if (Ingurgiteur.index == 3) {
			if (canCanon) {
				canon = Instantiate (canonACouleurs, spawnPosition, Quaternion.identity) as GameObject;
				cheksum++;
				canCanon = false;
				x = 42.954f; y = 0.99f; z = -5.56f;
				Invoke ("MoveCanonAfter", 1.0f);
			}
		}

		if (Input.GetKeyDown (KeyCode.Y)) {	
			if (!canCanon)
				canon.transform.Translate (Vector3.left);
			if (!canNuage)
				nuage.transform.Translate (Vector3.left);

		}
	}

	void MoveCanonAfter(){
		canon.transform.position = new Vector3 (x, y, z);
	}

	void MoveNuageAfter(){
		nuage.transform.position = new Vector3 (x, y, z);
	}
}
