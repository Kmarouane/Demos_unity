using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

	public static bool rotateD,rotateG,reset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(rotateD)
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (0, 90, 0), Time.deltaTime);

		if (rotateG)
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (0, -90, 0), Time.deltaTime);

		if (reset)
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (0, 0, 0), Time.deltaTime);
	}

}
