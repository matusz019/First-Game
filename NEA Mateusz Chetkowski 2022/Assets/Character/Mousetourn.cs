using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousetourn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var dir = Input.mousePosition - Camera.main.WorldToScreenPoint (transform.position);			//This line gets the vector between the mouse and the game object by subtracting them from eachother
		var angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;					//This line caclulates the angle between the vectors on the plane and then converts them both to degrees
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);		//This line rotates the sprite to the corresponding angle
	}
}
