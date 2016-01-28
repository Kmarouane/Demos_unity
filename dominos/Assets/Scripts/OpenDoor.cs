using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OpenDoor : MonoBehaviour {

	float smooth = 2.0f;
	float angle = 135f;
	GameObject porte;
	GameObject joueur;

	// Use this for initialization
	void Start () {
		porte = GameObject.Find ("PivotPorte");
		joueur = GameObject.Find ("FPSController");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.M)) {
			Level2Transition ();
		}

	}

	public void Level2Transition(){
		transform.Rotate (Vector3.up, angle , Space.Self);
		//transform.eulerAngles = Vector3.Slerp (transform.eulerAngles, new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y + angle, transform.eulerAngles.z), Time.deltaTime * smooth);
		//GameObject.Find ("LevelText").GetComponent<Text> ().text = "Level 2";
		if(joueur.transform.position.x>porte.transform.position.x)
			GameObject.Find ("LevelText").GetComponent<Text> ().text = "Level 2";
	}
}
