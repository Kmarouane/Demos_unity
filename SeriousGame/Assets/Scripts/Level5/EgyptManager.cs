using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EgyptManager : MonoBehaviour {

	public static int etape = 0;
	GameObject messages;
	string[] scripts = {
		"Approchez, visiteur !",
		"Vous êtes maintenant prisonnier de ce temple, tout comme moi",
		"cependant, vous pouvez en sortir..",
		"Pour cela, vous devez construire un édifice assez haut",
		"pour atteindre la sortie du toit.",
		"À vous de jouer!!",
		""
	};
	float[] largeurs = { 160, 420, 240, 360, 210, 150, 0};
	bool startDiscussion;
	public float delais;

	// Use this for initialization
	void Start () {
		messages = GameObject.Find ("Level5Messages");
		messages.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (LevelManager._level == 5) {
			//Debug.Log (etape + " , " + startDiscussion + " , " + currentTime);
			//messages.SetActive (true);

			if (etape == 0 && DialogTrigger.isNear) {
				startDiscussion = true;
			}

			messages.GetComponentInChildren<Text> ().text = scripts [etape];
			messages.GetComponent<RectTransform> ().sizeDelta = new Vector2 (largeurs [etape], 41.57f);

			if (etape == 5) {
				messages.SetActive (false);
				startDiscussion = false;
				ApparitionStele ();
			}

			if (Input.GetKeyDown (KeyCode.Space) && etape < scripts.Length - 1)
				etape++;
		}
	}

	void ApparitionStele(){
	}
}
