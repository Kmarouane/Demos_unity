using UnityEngine;
using System.Collections;

public class PyramidBuilder : MonoBehaviour {

	public GameObject model;
	Vector3 initial;
	public int n = 21, m = 21, o = 11;

	// Use this for initialization
	void Start () {
		initial = new Vector3 (85.5f, -7.06f, -71.87f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.B)) {
			for (int k = 0; k < o; k++) {
				for (int i = 1; i <= n; i++) {
					for (int j = 1; j <= m; j++) {
						Instantiate (model, new Vector3 (initial.x - (1 * (j - 1)), initial.y + 0.5f * k, initial.z + 1 * (i - 1)), Quaternion.identity);
					}
				}
				initial = new Vector3 (85.5f - (k + 1), -7.06f, -71.87f + (k + 1));
				n-=2;
				m-=2;
			}

		}
	}
}
