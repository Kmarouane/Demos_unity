using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public static bool followMe = false;
	public float moveSpeed = 2, rotSpeed = 2; 
	Transform joueur;

	// Use this for initialization
	void Start () {
		joueur = GameObject.Find ("FPSController").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (followMe) {
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (joueur.position - transform.position), rotSpeed * Time.deltaTime);
			if (Vector3.Distance (joueur.transform.position, transform.position) > 5)
				transform.position += transform.forward * moveSpeed * Time.deltaTime;
		}
	}
}
