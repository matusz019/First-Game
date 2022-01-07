using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerhealth : MonoBehaviour {

	public int health = 3;
	public Rigidbody2D rb;
	public bool shield = false;
	private int tempHealth = 9999;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "bullet" && shield == false) {
			health -= 1;
			//Debug.Log ("I have collided with bullet");
		} else if (col.gameObject.tag == "bullet" && shield == true) {
			tempHealth -= 1;
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.name == "Armour"){
			health += 1;
			Debug.Log ("I have picked up armour");
		}
		if (col.name == "Shield") {
			Destroy (col.gameObject);
			Debug.Log ("I have picked up Shield");
			StartCoroutine (invincibility());
		}
	}



	IEnumerator invincibility()
	{
		Debug.Log ("You are invincible");
		shield = true;
		yield return new WaitForSeconds (5);
		shield = false;
		Debug.Log ("You are no longer invincible");
	}

	void Update(){
		if (health == 0){
			Destroy (gameObject);
			DeathScreen ();
		}
	}
	public void DeathScreen()
	{
		SceneManager.LoadScene (2);						// Loads the main menu 
	}
}

