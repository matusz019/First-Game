using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			Destroy (gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
