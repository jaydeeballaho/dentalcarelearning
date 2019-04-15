using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour {

	private float speed = 0.5f;

	void Update(){
		if (PlayerController.paused == false) {
			if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {
				Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
				transform.Translate (touchDeltaPosition.x * speed, 0, 0);
			}
		}
	}

}
