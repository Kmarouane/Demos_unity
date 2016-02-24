using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public static int _level = 1;
	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Level : " + _level;
	}
}
