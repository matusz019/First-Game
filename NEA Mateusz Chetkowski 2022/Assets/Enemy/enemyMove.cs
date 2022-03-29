/*
 * created: Sprint 4
 * Last Edited: Sprint 4
 * Purpose: This script manages the movement of my patrolling enemies
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour {


	public Rigidbody2D rb;
	private float speed = 2f;
	private bool moveLeft = true;

	// Use this for initialization
	void Update () {											//if move left is not true then the enemy moves right and if its true then it moves left
		if (moveLeft == true) {
			rb.velocity = transform.up * speed;
		} else {
			rb.velocity = transform.up * -speed;
		}
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D col){						//When the enemy collides with the corresponding trigger the moveLeft variable changes accordingly
		if(col.gameObject.tag == "colL"){
			moveLeft = false;
			//Debug.Log ("I have collided with left");
		}
		if (col.gameObject.tag == "colR") {
			moveLeft = true;
			//Debug.Log ("I have collided with right");
		}
	}
}
