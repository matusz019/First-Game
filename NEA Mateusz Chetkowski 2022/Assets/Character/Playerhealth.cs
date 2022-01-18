using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Playerhealth : MonoBehaviour {

	private int easyHealth = 5;
	private int mediumHealth = 3;
	private int hardHealth = 1;
	public int health = 0;
	public Rigidbody2D rb;
	public bool shield = false;
	private int tempHealth = 9999;
	public string difficulty = "";
	public TextMeshPro healthText;


	// Use this for initialization
	void Start () {
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
			Debug.Log ("I have picked up Shield");
			StartCoroutine (invincibility());
			Destroy (col.gameObject);
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

