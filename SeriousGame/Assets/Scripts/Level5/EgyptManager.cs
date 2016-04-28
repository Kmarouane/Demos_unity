using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class EgyptManager : MonoBehaviour {

	public static int etape = 0;
	GameObject cadre, text, stele, mur, pharaon;
	string[] scripts = {
		"Approchez, visiteur !",
		"Vous êtes maintenant prisonnier de ce temple, tout comme moi",
		"cependant, vous pouvez en sortir..",
		"Pour cela, vous devez construire un édifice assez haut",
		"pour atteindre la sortie du toit.",
		"Vous avez à votre disposition, cette stèle..",
		"Construisez votre édifice en utilisant l'algorithme adéquat",
		"et revenez me voir quand vous aurez terminé",
		"bonne chance",
		"Ha ha ha !!",
		""
	};
	float[] largeurs = { 0.9f, 2.05f, 1.17f, 1.8f, 1.1f, 1.52f, 1.96f, 1.6f, 0.68f, 0.68f, 0 };
	bool startDiscussion, letHimClimb;
	public float delais;

	// Use this for initialization
	void Start () {
		cadre = GameObject.Find ("lvl5DialogCadre");
		text = GameObject.Find ("lvl5DialogText");
		stele = GameObject.Find ("stele");
		mur = GameObject.Find ("MurDePorte");
		pharaon = GameObject.Find ("Pharaon");
		cadre.SetActive (false);
		text.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (LevelManager._level == 5) {

			cadre.SetActive (true);
			text.SetActive (true);

			if(DialogTrigger.isNear)
				startDiscussion = true;

			text.GetComponent<TextMesh> ().text = scripts [etape];
			cadre.transform.localScale = new Vector3 (largeurs [etape], 0.2f, 0.008f);

			if (etape == 10) {
				cadre.SetActive (false);
				text.SetActive (false);
				startDiscussion = false;
				ApparitionStele ();
			}

			if (Input.GetKeyDown (KeyCode.Space) && etape < scripts.Length && startDiscussion) {
				GameObject.Find("Pharaon").GetComponent<Animator> ().SetBool ("pharaonAwake", true);
				etape++;
			}
			Debug.Log (startDiscussion);
			if (Input.GetKeyDown (KeyCode.Space)){
				if (EgyptTrigger1.distance1 == 6 &&
				    EgyptTrigger2.distance2 == 6 &&
				    EgyptTrigger3.distance3 == 6 &&
				    EgyptTrigger4.distance4 == 4 &&
				    EgyptTrigger7.distance7 == 2 &&
				    EgyptTrigger8.distance8 == 2) {
					GameObject.Find ("Pharaon").GetComponent<Animator> ().SetBool ("pyramidBuilt", true);
					PyramidBuilder.build = true;
					startDiscussion = false;
					letHimClimb = true;
					Invoke ("gotoMenu", 5f);
				}
			}
			if(letHimClimb)
				pharaon.transform.position = Vector3.Slerp (pharaon.transform.position, new Vector3 (pharaon.transform.position.x, -2.2f, -24f), 0.2f * Time.deltaTime);
		}
	}

	void ApparitionStele(){
		stele.transform.position = Vector3.Slerp (stele.transform.position, new Vector3 (stele.transform.position.x, -4.5f, stele.transform.position.z), 0.2f * Time.deltaTime);
		mur.transform.position = Vector3.Slerp (mur.transform.position, new Vector3 (mur.transform.position.x, -0.6f, mur.transform.position.z), 0.2f * Time.deltaTime);
		mur.transform.localScale = Vector3.Slerp (mur.transform.localScale, new Vector3 (0.5f, 2.4f, 2.4279f), 0.2f * Time.deltaTime);
	}

	void gotoMenu () {
		SceneManager.LoadScene (0);
	}
}
