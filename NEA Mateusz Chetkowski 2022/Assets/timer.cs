using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {

	public TextMeshPro timerText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timerText.text = "Time: " + Time.timeSinceLevelLoad.ToString ("00.00");

	}
	//void ResetTimer(){
	//	if (SceneManager.GetActiveScene() == 2){
	//		
	//	}
	//}
}
