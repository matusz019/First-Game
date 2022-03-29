/*
 * created: Sprint 6
 * Last Edited: Sprint 6
 * Purpose: This script makes it so that the enemy shoots every second
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform firePos;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Reload", 0.1f, 1.0f);		//This calls the method reload with the time after it is called and then how often it is repeated
	}

	void Reload(){
		Instantiate (bulletPrefab, firePos.position, firePos.rotation);				
	}

}
