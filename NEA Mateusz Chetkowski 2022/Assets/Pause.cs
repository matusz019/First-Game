using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

	public bool paused = false;
	public Image myPanel;
	public Graphic myText;
	//float fadeTime = 0f;
	Color colourToFadeTo;
	Color textColourToFadeTo;

	// Use this for initialization
	void Start () {
		colourToFadeTo = new Color (0f, 0f, 0f, 0f);
		myPanel.CrossFadeColor (colourToFadeTo, 0f, true, true);
		myText.CrossFadeColor (colourToFadeTo, 0f, true, true);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P) && paused == false) {
			Debug.Log ("should be paused");
			colourToFadeTo = new Color (0f, 0f, 0f, 0.5f);
			textColourToFadeTo = new Color (1f, 1f, 1f, 1f);
			myPanel.CrossFadeColor (colourToFadeTo, 0f, true, true);
			myText.CrossFadeColor (textColourToFadeTo, 0f, true, true);
			Time.timeScale = 0.0f;
			paused = true;
		}
		if (Input.GetKeyDown (KeyCode.Escape) && paused == true){
			Debug.Log ("should be unpaused");
			Time.timeScale = 1.0f;
			colourToFadeTo = new Color (0f, 0f, 0f, 0f);
			myPanel.CrossFadeColor (colourToFadeTo, 0f, true, true);
			myText.CrossFadeColor (colourToFadeTo, 0f, true, true);
			paused = false;
		}
	}
}
