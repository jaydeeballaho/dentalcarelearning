using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementCamera : MonoBehaviour {

	public SpriteRenderer sprite;

	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		PlayerRestriction ();
	}

	void PlayerRestriction () {
		Vector3 playerSize = sprite.bounds.size;

		// Here is the definition of the boundary in world point
		var distance = (transform.position - Camera.main.transform.position).z;

		var leftBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distance)).x + (playerSize.x/2);
		var rightBorder = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, distance)).x - (playerSize.x/2);

		var bottomBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distance)).y + (playerSize.y/2);
		var topBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0,1, distance)).y - (playerSize.y/2);

		// Here the position of the player is clamped into the boundaries
		transform.position = (new Vector3 (
			Mathf.Clamp (transform.position.x, leftBorder, rightBorder),
			Mathf.Clamp (transform.position.y, bottomBorder+35 , topBorder),
			transform.position.z)
		);

	}

}
