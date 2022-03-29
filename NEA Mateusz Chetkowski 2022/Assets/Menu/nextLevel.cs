/*
 * created: Sprint 14
 * Last Edited: Sprint 14
 * Purpose: This script will detect the collision between the player and an invisible collider and then 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player"){
			SceneManager.LoadScene (3);
		}
	}
}
