using UnityEngine;
using System.Collections;

public class PorterJeton : MonoBehaviour {

	GameObject mainCamera;
	GameObject objetAPorter;
	bool porteUnObjet;
	public float distance;

	public Texture2D curseur;
	int xpos;

	// Use this for initialization
	void Start () {
		mainCamera = GameObject.FindWithTag ("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		if (LevelSelector.selector) {
			xpos = 20 * (LevelSelector.goToLvl - 1);
			if (LevelSelector.goToLvl == 4)
				xpos = 76;
			transform.position = new Vector3 (xpos, 2, -3);
			LevelSelector.selector = false;
		}
		if (porteUnObjet) {
			Porter (objetAPorter);
			TestRelachement ();
		} else {
			Ramasser ();
		}
	}

	void Porter(GameObject o){
		o.transform.position = mainCamera.transform.position + mainCamera.transform.forward * distance;
	}

	void Ramasser(){		
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0) || Input.GetButton("BoutonXManette")) {
			int x = Screen.width / 2;
			int y = Screen.height / 2;

			Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x,y));
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				
				APorter p = hit.collider.GetComponent<APorter> ();
				if (p != null) {
					Cursor.SetCursor (curseur, Vector2.zero, CursorMode.Auto);//*****************************************
					porteUnObjet = true;
					objetAPorter = p.gameObject;
				}
			}
		}
	}

	void TestRelachement (){
		if (Input.GetKeyDown (KeyCode.Space)  || Input.GetMouseButtonDown(0) || Input.GetButton("BoutonXManette")) {
			Relacher ();
		}
	}

	void Relacher (){
		porteUnObjet = false;
		objetAPorter = null;
		Cursor.SetCursor (null, Vector2.zero, CursorMode.Auto);//*****************************************
	}
}
