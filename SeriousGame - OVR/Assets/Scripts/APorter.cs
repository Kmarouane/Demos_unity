using UnityEngine;
using System.Collections;

public class APorter : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "LPSolutions") 
			Physics.IgnoreCollision (col.gameObject.GetComponent<Collider> (), GetComponent<Collider> ());
		if (col.gameObject.name == "LevelPrimeArrow")
			Physics.IgnoreCollision (col.gameObject.GetComponent<Collider> (), GetComponent<Collider> ());
		if (col.gameObject.name == "FPSController")
			Physics.IgnoreCollision (col.gameObject.GetComponent<Collider> (), GetComponent<Collider> ());
	}
	/*
	void FixedUpdate(){
		
		if (transform.position.y < 0)
			transform.position = new Vector3 (transform.position.x, 3.0f, transform.position.z);
	}
*/
	void OnCollisionStay(Collision hit){
		if (hit.gameObject.name.Equals ("Assenceur"))
			transform.parent = hit.transform;
		else
			transform.parent = null;
	}
}
