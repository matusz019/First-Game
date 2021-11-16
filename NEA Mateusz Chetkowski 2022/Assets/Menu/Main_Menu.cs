/*
 * created: Sprint 1
 * Last Edited: Sprint 1
 * Purpose: This script manages the navigation of my buttons
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour {

	public string Difficulty = "";						//Declaring the diffculty variable


	public void PlayGame ()
	{
		SceneManager.LoadScene(1);						//Loads the game scene
	}
	/*public void SettingMenu ()
	{
		SceneManager.LoadScene(2);						// Loads the setting menu scene
	}


	public void ReturnToMenuButton()
	{
		SceneManager.LoadScene (0);						// Loads the main menu 
	}*/

	public void EasyDifficulty ()
	{
		Difficulty = "Easy";
		Debug.Log ("Difficulty = Easy");				// Sets difficulty setting to easy
	}
	public void NormalDifficulty ()
	{
		Difficulty = "Normal";
		Debug.Log ("Difficulty = Normal");				//Sets difficulty setting to normal
	}
	public void HardDifficulty ()
	{
		Difficulty = "Hard";
		Debug.Log ("Difficulty = Hard");				//Sets difficulty setting to hard
	}

		
	public void QuitGame ()
	{
		Debug.Log ("QUIT");								//Exits the game
	}
}
/*This code gets the active scene inside the build index and then adds one to the build index in order to go to the next scene.
I figured out how to do this by looking through Unity documentation during my spare time.*/