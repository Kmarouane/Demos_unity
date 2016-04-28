using UnityEngine;
using System.Collections;

public class Iterations : MonoBehaviour {

	public static int _iteration = 1;

	public GameObject suivant;
	public GameObject precedent;

	public Transform s_position;
	public Transform p_position;

	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.name.Contains("SuivantCube") && _iteration<6 && ChangeColor.verification[_iteration-1]!=0) {			
			_iteration++;
			col.gameObject.transform.position=s_position.position;
		}
		if (col.gameObject.name.Contains("PrecedentCube") && _iteration>1) {			
			_iteration--;
			col.gameObject.transform.position=p_position.position;
		}

	}
		
}
