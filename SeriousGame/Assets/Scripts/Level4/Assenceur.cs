using UnityEngine;
using System.Collections;

public class Assenceur : MonoBehaviour {

	public Transform depart;
	public Transform arrivee;
	public float vitesse;
	int direction;

	void Update() {
		if (LevelManager._level == 4) {
			if (direction == 1)
				transform.position = Vector3.Slerp (transform.position, arrivee.position, vitesse * Time.deltaTime);
			else
				transform.position = Vector3.Slerp (transform.position, depart.position, vitesse * Time.deltaTime);
		}
	}

	void OnMouseDown() {
		if (direction == 1)
			direction = 0;
		else
			direction = 1;
	}
}
