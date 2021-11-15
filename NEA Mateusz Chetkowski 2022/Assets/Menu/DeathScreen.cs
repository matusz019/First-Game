/*
 * created: Sprint 7
 * Last Edited: Sprint 7
 * Purpose: This script manages the navigation of my "Return to Menu" button
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour {

	public void ReturnToMenu ()
	{
		SceneManager.LoadScene(0);					//Loads the game scene
	}
}
