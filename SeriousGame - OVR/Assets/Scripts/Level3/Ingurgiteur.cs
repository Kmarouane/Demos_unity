using UnityEngine;
using System.Collections;

public class Ingurgiteur : MonoBehaviour {

	public static int index = 0;
	public static int nbDominos = 0;
	public static bool canInstantiateDomino = false;

	void OnTriggerEnter(Collider col){
		
		if (col.gameObject.name.Contains("LevelPrimeJeton")) {
			index = int.Parse (col.name.Substring (15, 1));
			if (index == IngurgiteurCondition.firstIndex) {
				if (index == 7 && nbDominos < 9) {
					nbDominos++;
					canInstantiateDomino = true;
				}
				Destroy (col.gameObject.GetComponent<APorter> ());
				Destroy (col.gameObject);
				Instantiate (col.gameObject, new Vector3 (52.3f, 0.7f, -3.37f), Quaternion.identity);
				Invoke("ResetIndex", 2.0f);
			}
		}

	}

	void ResetIndex(){
		index = 0;
	}
}
