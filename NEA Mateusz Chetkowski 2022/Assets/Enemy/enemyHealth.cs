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
	public GameObject armour;
	public GameObject shield;
	public GameObject bGun;
	public GameObject aGun;
	private GameObject flash;
	public GameObject can;
	public GameObject cuffs;
	private Vector2 position;



	// Use this for initialization
	void Start () {
		flash = GameObject.FindGameObjectWithTag ("Flashbang");
	}
	
	//Update is called once per frame
	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "bullet") {
			health -= 1;
			//Debug.Log ("I have collided with bullet");
		}
	}

	void Update(){
		position = gameObject.transform.position;
		if (health == 0){
			chance1 = Random.Range (1, 20);
			if (chance1 == 15) {
				Instantiate (armour, position, Quaternion.identity);
			} else if (chance1 == 1) {
				Instantiate (shield, position, Quaternion.identity);
			} else if (chance1 == 2) {
				Instantiate (bGun, position, Quaternion.identity);
			} else if (chance1 == 3) {
				Instantiate (aGun, position, Quaternion.identity);
			} else if (chance1 == 4) {
				Instantiate (flash, position, Quaternion.identity);
			} else if (chance1 == 5) {
				Instantiate (can, position, Quaternion.identity);
			} else if (chance1 == 6) {
				Instantiate (cuffs, position, Quaternion.identity);
			}
			Destroy (gameObject);


		}
	}
}