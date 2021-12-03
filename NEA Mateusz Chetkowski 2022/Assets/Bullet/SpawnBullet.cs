/*
 * created: Sprint 2
 * Last Edited: Sprint 2
 * Purpose: This script makes it so that the bullet spawn when the left mouse button is pressed
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform firePos;
	public bool haveGun = false;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			Instantiate (bulletPrefab, firePos.position, firePos.rotation);
			//Debug.Log ("shoot!");
		}
		if (haveGun == true) {
			if (Input.GetKey (KeyCode.Mouse0)) {
				Instantiate (bulletPrefab, firePos.position, firePos.rotation);
			}
		}
	}
	void OnTriggerEnter2D(Collider2D col){
		
		if (col.gameObject.tag == "Gun") {
			Destroy (col.gameObject);
			StartCoroutine (AutoGun());
			Debug.Log ("I have picked up gun");
		}
	}

	IEnumerator AutoGun()
	{
		haveGun = true;
		yield return new WaitForSeconds (5);
		haveGun = false;
	}
}