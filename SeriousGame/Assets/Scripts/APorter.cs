using UnityEngine;
using System.Collections;

public class APorter : MonoBehaviour {

	void FixedUpdate(){
		if (transform.position.y < 0)
			transform.position = new Vector3 (transform.position.x, 3.0f, transform.position.z);
	}
}
