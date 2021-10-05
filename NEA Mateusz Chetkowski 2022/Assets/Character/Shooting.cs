/*
 * created: Sprint 3
 * Last Edited: Sprint 3
 * Purpose: This script instantiates the bullet and adds a velocity to it
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public GameObject bullet;
	public Transform firePos;
	public float bulletSpeed = 20f;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Mouse0))
		{
			Shoot();
		}
	}

	void Shoot()
	{
		GameObject bullet = Instantiate (bullet, firePos.position, firePos.rotation);
		Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
		rb.AddForce (firePos.up = bulletSpeed, ForceMode2D.Impulse);
	}
}
