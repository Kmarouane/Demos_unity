using UnityEngine;
using System.Collections;

public class EgyptManager : MonoBehaviour {

	int etape = 0;
	GameObject messages;

	// Use this for initialization
	void Start () {
		messages = GameObject.Find ("Level5Messages");
		messages.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (LevelManager._level == 5) {
			if (etape == 0) {
				messages.SetActive (true);
			}
		}
	}
}
