using UnityEngine;
using System.Collections;

public class DestroyTheBall : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name.Contains ("DominoIntermediaire")) {
			col.gameObject.GetComponent<Renderer> ().material.color = gameObject.GetComponent<Renderer> ().material.color;
			Destroy (gameObject);
		}
	}
}
