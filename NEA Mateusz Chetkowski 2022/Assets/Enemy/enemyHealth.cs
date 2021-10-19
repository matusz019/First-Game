using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour {

	public int health = 3;
	public Rigidbody2D rb;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D col){
		if (col.gameObject.tag == "bullet") {
			health -= 1;
			Debug.Log ("I have collided with bullet");
		}
	}

	void Update(){
		if (health == 0){
			Destroy (gameObject);
		}
	}
}