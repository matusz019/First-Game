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

	void Update () {

		transform.position = new Vector3 (player.position.x, player.position.y, offset.z);				//changes the position of the camera to the player with an offset in the z axis

	}
}
