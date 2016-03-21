using UnityEngine;
using System.Collections;

public class SimuleLevelPrime : MonoBehaviour {

	public static bool clicked ;
	ParticleSystem thunderP, thunderP2, rainP, cannonP;
	GameObject lumiere, ballEmitter, porteD, porteG;
	public float speed = 15.0f;
	public GameObject ball;
	public Transform ballSource;
	Color[] couleurs = { Color.yellow, Color.blue };
	bool cFinit = false;
	public static int canSimulate = 0;

	void Start() {
		thunderP = GameObject.Find ("ThunderParticleSystem").GetComponent<ParticleSystem> ();
		thunderP2 = GameObject.Find ("ThunderPS2").GetComponent<ParticleSystem> ();
		rainP = GameObject.Find ("DropParticleSystem").GetComponent<ParticleSystem> ();
		cannonP = GameObject.Find ("FireBallParticleSystem").GetComponent<ParticleSystem> ();
		lumiere = GameObject.Find ("Directional Light");
		ballEmitter = GameObject.Find ("LevelPrimeBallEmitter");
		porteD = GameObject.Find ("LevelPrimePorteDroite");
		porteG = GameObject.Find ("LevelPrimePorteGauche");
	}

	void Update(){
		if (canSimulate == 5 && !cFinit) {
			GetComponent<Animator> ().enabled = true;
		}
		if (cFinit)
			OuvrirPortes ();
		if (LevelManager._level == 4)
			FermerPortes ();
	}
	IEnumerator OnMouseDown() {

		if (!cFinit && canSimulate == 5) {
			GetComponent<Animator> ().enabled = false;
			Iterations._iteration = 0;
			for (int i = 0; i < Ingurgiteur.nbDominos; i++) {
				Iterations._iteration++;
				FireTheBall ();
				yield return new WaitForSeconds (1.0f);

				if (i % 2 == 0) {
					Thunder ();
					yield return new WaitForSeconds (0.5f);
				} else {
					Rain ();	
					yield return new WaitForSeconds (1.5f);
				}				

				Manager.dominosTableau [i].GetComponent<Rigidbody> ().isKinematic = false;
				Manager.dominosTableau [i].GetComponent<Renderer> ().material.color = couleurs [i % 2];

				if (i == 0)
					Manager.dominosTableau [i].GetComponent<Rigidbody> ().AddForce (-10, 0, 0);

				if (i < Ingurgiteur.nbDominos - 1) {
					Manager.TranslateCannon ();
					ballEmitter.transform.Translate (Vector3.left);
					cannonP.transform.Translate (Vector3.left);

					Manager.TranslateNuage ();
					thunderP.transform.Translate (Vector3.left);
					rainP.transform.Translate (Vector3.left);
				}

				yield return new WaitForSeconds (1.0f);

			}
			yield return new WaitForSeconds (1.0f);
			LevelManager.levelCompleted = true;
			cFinit = true;
		}
	}

	void Thunder() {
		lumiere.GetComponent<Light> ().intensity = 0.0f;
		thunderP.GetComponent<Light> ().enabled = true;
		thunderP.Play ();
		thunderP.startLifetime = thunderP.startLifetime;
		thunderP2.Play ();
		thunderP2.startLifetime = thunderP2.startLifetime;
		Invoke ("ResetIntensity", 0.30f);
	}

	void Rain(){
		rainP.Play ();
		rainP.startLifetime = rainP.startLifetime;
	}

	void ResetIntensity(){
		thunderP.GetComponent<Light> ().enabled = false;
		lumiere.GetComponent<Light> ().intensity = 0.64f;
	}

	public void FireTheBall(){
		cannonP.Play ();
		cannonP.startLifetime = cannonP.startLifetime;
		GameObject bouleDeFeu = Instantiate (ball, ballEmitter.transform.position, Quaternion.identity) as GameObject;
		bouleDeFeu.GetComponent<Rigidbody> ().velocity = transform.TransformDirection (new Vector3 (0, 0, speed*2));
	}

	void OuvrirPortes (){
		porteD.transform.position = Vector3.Slerp (porteD.transform.position, new Vector3 (63, 3, -3), 0.4f * Time.deltaTime);
		porteG.transform.position = Vector3.Slerp (porteG.transform.position, new Vector3 (63, 3, 3), 0.4f * Time.deltaTime);
	}

	void FermerPortes (){
		porteD.transform.position = Vector3.Slerp (porteD.transform.position, new Vector3 (63, 3, -0.6f), 2f * Time.deltaTime);
		porteG.transform.position = Vector3.Slerp (porteG.transform.position, new Vector3 (63, 3, 0.6f), 2f * Time.deltaTime);
	}

}