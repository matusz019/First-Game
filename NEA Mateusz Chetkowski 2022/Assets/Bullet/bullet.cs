using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	private float speed = 20f;
	public Rigidbody2D rb;

	

	// Use this for initialization
	void Start () {
		rb.velocity = transform.right * speed;
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D()
	{
		Destroy(gameObject);
	}
}
