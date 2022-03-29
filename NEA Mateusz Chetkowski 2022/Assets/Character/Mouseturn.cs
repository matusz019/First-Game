/*
 * created: Sprint 2
 * Last Edited: Sprint 11
 * Purpose: This script makes it so that the sprite rotates towards the mouse pointer and makes the character move
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouseturn : MonoBehaviour {
	//Declaring variables
	public Rigidbody2D rb;
	public float movespeed = 5f;
	Vector2 movement;
	Vector2 mousePos;
	public Camera cam;
	
	// Update is called once per frame
	void Update () {
		movement.x = Input.GetAxisRaw ("Horizontal");
		movement.y = Input.GetAxisRaw ("Vertical");
		mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
		//This piece of code gets the position of the mouse and maps it to a point on the screen as well as getting the input for the movement of the character
	}

	void FixedUpdate()
	{
		rb.MovePosition (rb.position + movement * movespeed * Time.fixedDeltaTime);
		Vector2 dir = mousePos - rb.position;
		float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
		rb.rotation = angle;
		//This piece of code works out the angle between the mouse and the sprite, then sets the rotation of the rigid body of the sprite, in order for it to point to the mouse
	}
	void OnTriggerEnter2D(Collider2D col){				//This piece of code detects the collision between the buff object and then destroys it after starting the co-routine

		if (col.gameObject.tag == "Can") {
			Destroy (col.gameObject);
			StartCoroutine (SpeedBuff());
			//Debug.Log ("I have picked up can");
		}
		if (col.gameObject.tag == "Handcuffs") {
			Destroy (col.gameObject);
			StartCoroutine (SpeedDebuff());
			//Debug.Log ("I have picked up Handcuffs");
		}
	}

	IEnumerator SpeedBuff()						//These methods increase or decrease the players speed epending on which buff they have picked up
	{
		movespeed = 10f;
		yield return new WaitForSeconds (5);
		movespeed = 5f;
	}
	IEnumerator SpeedDebuff()
	{
		movespeed = 2.5f;
		yield return new WaitForSeconds (5);
		movespeed = 5f;
	}
}
