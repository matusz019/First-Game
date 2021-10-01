/*
 * created: Sprint 2
 * Last Edited: Sprint 2
 * Purpose: This script manages the tracking of the camera to my character
 */





using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camtracking : MonoBehaviour {

	public Transform player;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (player.position.x, player.position.y, offset.z);

	}
}
