/*
 * created: Sprint 14
 * Last Edited: Sprint 14
 * Purpose: This script detects if the player interacted with the necessary trigger then shows the winning screen
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player"){
			SceneManager.LoadScene (4);
		}
	}
}