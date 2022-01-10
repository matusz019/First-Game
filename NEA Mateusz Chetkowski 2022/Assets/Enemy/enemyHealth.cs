/*
 * created: Sprint 5
 * Last Edited: Sprint 12
 * Purpose: This script makes it so that the enemies disappear after being shot 3 times, then instantiates a buff or a debuff where they died
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemyHealth : MonoBehaviour {

	private int health = 3;
	public Rigidbody2D rb;
	private int chance1 = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	//Update is called once per frame
	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "bullet") {
			health -= 1;
			//Debug.Log ("I have collided with bullet");
		}
	}

	void Update(){
		if (health == 0){
			//chance1 = Random.Range (1, 10);
			//if (chance1 == 10){
			//	Instantiate 
			//}
			Destroy (gameObject);

		}
	}
}