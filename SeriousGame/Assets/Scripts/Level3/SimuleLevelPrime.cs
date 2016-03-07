using UnityEngine;
using System.Collections;

public class SimuleLevelPrime : MonoBehaviour {

	public static bool clicked ;
	ParticleSystem thunderP, thunderP2, rainP, cannonP;
	GameObject lumiere;
	public float speed = 15.0f;
	public GameObject ball;
	public Transform ballSource;

	void Start() {
		thunderP = GameObject.Find ("ThunderParticleSystem").GetComponent<ParticleSystem> ();
		thunderP2 = GameObject.Find ("ThunderPS2").GetComponent<ParticleSystem> ();
		rainP = GameObject.Find ("DropParticleSystem").GetComponent<ParticleSystem> ();
		cannonP = GameObject.Find ("FireBallParticleSystem").GetComponent<ParticleSystem> ();
		lumiere = GameObject.Find ("Directional Light");
	}

	IEnumerator OnMouseDown() {

		for (int i = 0; i < Ingurgiteur.nbDominos; i++) {

			//lanceur.FireTheBall (cannonP);
			FireTheBall ();
			yield return new WaitForSeconds (1.0f);


			if (i % 2 == 0)
				Thunder ();
			else
				Rain ();
			yield return new WaitForSeconds (0.5f);

			Manager.dominosTableau [i].GetComponent<Rigidbody> ().isKinematic = false;

			if (i == 0)
				Manager.dominosTableau [i].GetComponent<Rigidbody> ().AddForce (-10, 0, 0);
			//manage.TranslateNuage ();

			yield return new WaitForSeconds (1.0f);
			Manager.TranslateNuage ();
			thunderP.transform.Translate (Vector3.left);
			rainP.transform.Translate (Vector3.left);
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
		GameObject bouleDeFeu = Instantiate (ball, ballSource.position + new Vector3 (0f, 1.5f, 1.045f), Quaternion.identity) as GameObject;
		bouleDeFeu.GetComponent<Rigidbody> ().velocity = transform.TransformDirection (new Vector3 (0, 0, speed));
	}

}
