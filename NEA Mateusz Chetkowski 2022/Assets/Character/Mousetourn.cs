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
	void OnTriggerEnter2D(Collider2D col){

		if (col.gameObject.tag == "Can") {
			Destroy (col.gameObject);
			StartCoroutine (SpeedBuff());
			Debug.Log ("I have picked up can");
		}
		if (col.gameObject.tag == "Handcuffs") {
			Destroy (col.gameObject);
			StartCoroutine (SpeedDebuff());
			Debug.Log ("I have picked up Handcuffs");
		}
	}

	IEnumerator SpeedBuff()
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
