using UnityEngine;
using System.Collections;

public class TiroirApparition : MonoBehaviour {

	public GameObject tiroir;
	public GameObject jeton;
	public GameObject text;

	void OnTriggerEnter(Collider col){
		if (InitLevel2.niveauInitialise > 0) {
			
			if (col.name.Contains(jeton.name)) {
				if(jeton.name.Contains("JetonTantQue"))
					Instantiate (tiroir,tiroir.transform.position,Quaternion.identity);
				else
					Instantiate (tiroir,tiroir.transform.position,Quaternion.identity);
				
				Destroy (gameObject);
				Destroy (text.gameObject);

			}
		}
	}
}
