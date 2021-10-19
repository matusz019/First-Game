using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform firePos;

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			Instantiate (bulletPrefab, firePos.position, firePos.rotation);
			//Debug.Log ("shoot!");
		}
	}
}
