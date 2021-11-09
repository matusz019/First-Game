using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform firePos;
	public bool canShoot = true;


	// Use this for initialization
	void Start () {
		InvokeRepeating ("Reload", 0.1f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
			
		}
	void Reload(){
		Instantiate (bulletPrefab, firePos.position, firePos.rotation);
	}

}
