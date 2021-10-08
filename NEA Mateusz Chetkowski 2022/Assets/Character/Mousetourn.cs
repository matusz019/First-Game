/*
 * created: Sprint 2
 * Last Edited: Sprint 2
 * Purpose: This script makes it so that the sprite rotates towards the mouse pointer
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousetourn : MonoBehaviour {

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
	}

	void FixedUpdate()
	{
		rb.MovePosition (rb.position + movement * movespeed * Time.fixedDeltaTime);
		Vector2 dir = mousePos - rb.position;
		float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
		rb.rotation = angle;
	}
}
