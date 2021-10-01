using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camtracking : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var dir = GameObject.FindGameObjectWithTag ("MainCamera").transform.position;
		GameObject.FindGameObjectWithTag ("Player").transform.position = dir;
	}
}
