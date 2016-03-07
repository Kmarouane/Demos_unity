using UnityEngine;
using System.Collections;

public class FireBall : MonoBehaviour {

	public GameObject cannonBall;
	public float vitesse = 15.0f;
	ParticleSystem ballSmoke;

	// Use this for initialization
	void Start () {
		ballSmoke = GameObject.Find ("FireBallParticleSystem").GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.L)) {
			FireTheBall ();
		}
	}

	public void FireTheBall(){
		ballSmoke.Play ();
		ballSmoke.startLifetime = ballSmoke.startLifetime;
		GameObject bouleDeFeu = Instantiate (cannonBall, transform.position + new Vector3 (0f, 1.5f, 1.045f), Quaternion.identity) as GameObject;
		bouleDeFeu.GetComponent<Rigidbody> ().velocity = transform.TransformDirection (new Vector3 (0, 0, vitesse));
	}

}
