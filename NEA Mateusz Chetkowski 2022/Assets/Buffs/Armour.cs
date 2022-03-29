/*
 * created: Sprint 9
 * Last Edited: Sprint 9
 * Purpose: Detects collision between player and the armour and then destroyes the armour
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armour : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			Destroy (gameObject);
		}
	}
}
