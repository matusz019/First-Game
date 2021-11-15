using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerhealth : MonoBehaviour {

	public int health = 3;
	public Rigidbody2D rb;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "bullet") {
			health -= 1;
			Debug.Log ("I have collided with bullet");
		}
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

