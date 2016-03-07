using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	public static GameObject[] dominosTableau;
	public GameObject canonACouleurs;
	public GameObject nuageAFoudre;
	GameObject objetDomino;
	public static GameObject canon;
	public static GameObject nuage;
	public GameObject objetDominoGris;
	public GameObject objetDominoNoir;
	public Transform rotationTarget;
	public ParticleSystem cloudParticles, starParticles, thunderParticles, thunderParticles2, dropParticles;

	int taille = 9, currentDomino, checksum = 0;
	bool canNuage = true, canCanon = true, canWardrobe = true;
	float x, y, z;
	Vector3 spawnPosition;

	public GameObject armoireVide;
	public GameObject startButton;
	GameObject lightGlobal;

	// Use this for initialization
	void Start () {
		dominosTableau = new GameObject[taille];
		spawnPosition = new Vector3 (50.10654f, 2.48f, 9.99f);
		lightGlobal = GameObject.Find ("Directional Light");
	}
	
	// Update is called once per frame
	void Update () {
		if (currentDomino % 2 == 1)
			objetDomino = objetDominoNoir;
		else
			objetDomino = objetDominoGris;
		
		currentDomino = Ingurgiteur.nbDominos;
		//Debug.Log (currentDomino);
		if (Ingurgiteur.index == 7) {
			if (currentDomino > 0 && currentDomino < 10 && Ingurgiteur.canInstantiateDomino) {
				dominosTableau [currentDomino - 1] = Instantiate (objetDomino, new Vector3 (42.95f - (currentDomino - 1), 1.008f, 9.97f), Quaternion.RotateTowards (objetDomino.transform.rotation, rotationTarget.rotation, 15.0f)) as GameObject;
				cloudParticles.Play ();
				cloudParticles.startLifetime = cloudParticles.startLifetime;
				cloudParticles.transform.Translate (Vector3.left);
				Ingurgiteur.canInstantiateDomino = false;
				if (currentDomino == 4)
					checksum++;
			}
		} else if (Ingurgiteur.index == 6) {
			if (canNuage) {
				ActivateStars ();
				nuage = Instantiate (nuageAFoudre, spawnPosition, Quaternion.identity) as GameObject;
				nuage.GetComponent<Rigidbody> ().AddForce (0f, 500f, 0f);
				checksum++;
				canNuage = false;
				x = 42.95f; y = 5.0f; z = 9.95f;
				Invoke ("MoveNuageAfter", 2.5f);
			}
		} else if (Ingurgiteur.index == 5) {
			if (canCanon) {
				ActivateStars ();
				canon = Instantiate (canonACouleurs, spawnPosition, Quaternion.identity) as GameObject;
				canon.GetComponent<Rigidbody> ().AddForce (0, 200, 0);
				checksum++;
				canCanon = false;
				x = 42.948f; y = 0.263f; z = -5.56f;
				Invoke ("MoveCanonAfter", 2.5f);
			}
		}

		if (checksum >= 3 && canWardrobe) {
			Invoke ("InstantiateWardrobe", 2.0f);
			canWardrobe = false;
		}

		if (Input.GetKeyDown (KeyCode.Y)) {	
			if (!canCanon)
				TranslateCannon ();
			if (!canNuage)
				TranslateNuage ();
			thunderParticles.transform.Translate (Vector3.left);
			dropParticles.transform.Translate (Vector3.left);
			GameObject.Find ("FireBallParticleSystem").GetComponent<ParticleSystem> ().transform.Translate (Vector3.left);

		}
		if (Input.GetKeyDown (KeyCode.I)) {
			Thunder ();
		}
		if (Input.GetKeyDown (KeyCode.O)) {
			Rain ();
		}

		if (SimuleLevelPrime.clicked) {
			for (int u = 0; u < Ingurgiteur.nbDominos; u++) {
				if (u % 2 == 0)
					Thunder ();
				else
					Rain ();
			}
		}
	}

	public static void TranslateCannon(){
		canon.transform.Translate (Vector3.left);
	}

	public static void TranslateNuage(){
		nuage.transform.Translate (Vector3.left);
	}


	public void Thunder(){
		lightGlobal.GetComponent<Light> ().intensity = 0.0f;
		thunderParticles.GetComponent<Light> ().enabled = true;
		thunderParticles.Play ();
		thunderParticles.startLifetime = thunderParticles.startLifetime;
		thunderParticles2.Play ();
		thunderParticles2.startLifetime = thunderParticles2.startLifetime;
		Invoke ("ResetIntensity", 0.30f);
	}

	public void Rain(){
		dropParticles.Play ();
		dropParticles.startLifetime = dropParticles.startLifetime;
	}

	void ResetIntensity(){
		thunderParticles.GetComponent<Light> ().enabled = false;
		lightGlobal.GetComponent<Light> ().intensity = 0.64f;
	}

	void InstantiateWardrobe(){
		ActivateStars ();
		Instantiate (armoireVide, spawnPosition + new Vector3 (0, 4.0f, 0), Quaternion.identity);
		armoireVide.gameObject.GetComponent<Rigidbody>().isKinematic=false;
		Invoke ("DestroySpawner", 1.0f);
		GameObject.Find ("LevelPrimeArrow").GetComponent<Animator> ().Play ("FlecheVersLeBas2ndEtape", -1, 0f);

	}

	void DestroySpawner(){
		Destroy (GameObject.Find ("Spawner"));
		Instantiate (startButton, new Vector3 (49.671f, 0.363f, 9.46f), Quaternion.identity);
	}

	void ActivateStars(){
		starParticles.Play ();
		starParticles.startLifetime = starParticles.startLifetime;
	}

	void MoveCanonAfter(){
		canon.transform.position = new Vector3 (x, y, z);
		canon.GetComponent<Rigidbody> ().isKinematic = true;
	}

	void MoveNuageAfter(){
		nuage.transform.position = new Vector3 (x, y, z);
		nuage.GetComponent<Rigidbody> ().isKinematic = true;
	}
		
}
