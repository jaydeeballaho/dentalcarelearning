using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantVelocity : MonoBehaviour {

	public Vector2 velocity = Vector2.zero;

	private Rigidbody2D rbody2D;

	// Use this for initialization
	void Start () {
		rbody2D = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		rbody2D.velocity = velocity;
	}

	void Reset () {
		velocity.y = -160;
	}
		
}
