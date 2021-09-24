using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactermovement : MonoBehaviour {
	Rigidbody2D rb;
	float speed;

	// Use this for initialization
	void Start () {
		speed = 0.9f;
		rb = GetComponent<Rigidbody2D> ();	
	}
		
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		rb.AddForce (new Vector2 (moveHorizontal, moveVertical) * speed, ForceMode2D.Impulse);
	}
}
