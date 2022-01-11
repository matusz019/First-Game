using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour {

	public Transform target;
	public float speed = 3f;
	public Transform Player;
	public Transform Enemy;
	private float distance;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance (Enemy.position, Player.position);
		//Debug.Log (distance);
		if (Vector3.Distance(transform.position, target.position) > 1f)
		{
			RotateTowardsTarget();
		}
	}

	private void RotateTowardsTarget()
	{
		if (distance <= 6) {
			Vector2 direction = target.position - transform.position;
			direction.Normalize ();
			float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg;       
			transform.rotation = Quaternion.Euler (Vector3.forward * (angle));
		}
	}
}
