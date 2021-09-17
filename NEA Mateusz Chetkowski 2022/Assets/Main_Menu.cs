using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
		
	public void QuitGame ()
	{
		Debug.Log ("QUIT");
	}
}
//This code gets the active scene inside the build index and then adds one to the build index in order to go to the next scene.