using UnityEngine;
using System.Collections;

public class IngurgiteurCondition : MonoBehaviour {

	public static int firstIndex = 0;
	//public static int condition = 0;

	void OnTriggerEnter(Collider col){
		if (col.name.Contains ("LevelPrimeJeton")) {
			firstIndex = int.Parse (col.name.Substring (15, 1));
			//if (firstIndex == Ingurgiteur.index) {
			//	condition = 1;
			//}
			Invoke("InitIndex",2.3f);
		}
	}

	void InitIndex(){
		firstIndex = 0;
	}
}
