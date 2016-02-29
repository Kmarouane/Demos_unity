using UnityEngine;
using System.Collections;

public class APorter : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "LPSolutions") {
			Physics.IgnoreCollision (col.gameObject.GetComponent<Collider> (), GetComponent<Collider> ());
		}
	}

	void FixedUpdate(){
		if (transform.position.y < 0)
			transform.position = new Vector3 (transform.position.x, 3.0f, transform.position.z);
	}
}
