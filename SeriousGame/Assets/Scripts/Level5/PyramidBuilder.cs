using UnityEngine;
using System.Collections;

public class PyramidBuilder : MonoBehaviour {

	public GameObject model;
	Vector3 initial;
	public int n = 21, m = 21, o = 11;

	public static bool build;
	bool built;

	// Use this for initialization
	void Start () {
		initial = new Vector3 (85.5f, -6.8f, -71.87f);
	}
	
	// Update is called once per frame
	void Update () {
		if (LevelManager._level == 5 && build && !built) {
			//if (Input.GetKeyDown (KeyCode.B)) {
				for (int k = 0; k < o; k++) {
					for (int i = 0; i < n; i++) {
						for (int j = 0; j < m; j++) {
							Instantiate (model, new Vector3 (initial.x - j, initial.y + k, initial.z + i), Quaternion.identity);
						}
					}
					initial = new Vector3 (85.5f - (k + 1), -6.8f, -71.87f + (k + 1));
					n-=2;
					m-=2;
				}

			//}
			built = true;
			build = false;
		}
	}
}
