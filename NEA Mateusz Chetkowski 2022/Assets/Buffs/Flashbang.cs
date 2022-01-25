using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Flashbang: MonoBehaviour

{
	public Image myPanel;
	float fadeTime = 3f;
	Color colourToFadeTo;

	void Start () {
		colourToFadeTo = new Color (1f, 1f, 1f, 0f);
		myPanel.CrossFadeColor (colourToFadeTo, 0.1f, true, true);
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player"){
			StartCoroutine (Flash());

		}
	}

	IEnumerator Flash()
	{
		Debug.Log ("flashing in progress");
		colourToFadeTo = new Color (1f, 1f, 1f, 1f);
		myPanel.CrossFadeColor (colourToFadeTo, 0.1f, true, true);

		yield return new WaitForSeconds (1);
		Debug.Log ("I have been flashed");

		colourToFadeTo = new Color (1f, 1f, 1f, 0f);
		myPanel.CrossFadeColor (colourToFadeTo, fadeTime, true, true);
		Debug.Log ("Flashing done");
		Destroy (gameObject);
	}



}