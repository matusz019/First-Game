/*
 * created: Sprint 6
 * Last Edited: Sprint 14
 * Purpose: Manages the health of the player
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Playerhealth : MonoBehaviour {

	private int easyHealth = 5;
	private int mediumHealth = 3;
	private int hardHealth = 2;
	private int health = 0;
	public Rigidbody2D rb;
	public bool shield = false;
	private int tempHealth = 9999;
	public string difficulty = "";
	public TextMeshPro healthText;


	// Use this for initialization
	void Start () {															//sets the player's health depending on the difficulty chosen
		if (PlayerPrefs.GetString ("Difficulty") == "Easy") {
			health = easyHealth;
		} else if (PlayerPrefs.GetString ("Difficulty") == "Normal") {
			health = mediumHealth;
		} else if (PlayerPrefs.GetString ("Difficulty") == "Hard") {
			health = hardHealth;
		}
	}

	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "bullet" && shield == false) {
			health -= 1;											//decreases health by one if hit by the bullet and the shield buff isn't on
			//Debug.Log ("I have collided with bullet");
		} else if (col.gameObject.tag == "bullet" && shield == true) {
			tempHealth -= 1;										// decreases temporary health by one if hit by the bullet and shield buff is currently on
		}
		healthText.text = "Health: " + health.ToString();
	}

	void OnTriggerEnter2D(Collider2D col){							//adds one health if the armour is picked up
		if (col.name == "Armour"){
			health += 1;
			Debug.Log ("I have picked up armour");
			Destroy (col.gameObject);
		}
		if (col.name == "Shield") {									//start the invincibility co routine 
			Debug.Log ("I have picked up Shield");
			StartCoroutine (Invincibility());
			Destroy (col.gameObject);
		}
	}



	IEnumerator Invincibility()										//sets the value of shield to true for 5 seconds
	{
		Debug.Log ("You are invincible");
		shield = true;
		yield return new WaitForSeconds (5);
		shield = false;
		Debug.Log ("You are no longer invincible");

	}

	void Update(){													//if the helath reaches zero the player character is destroyed and the you lose screen is loaded
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

