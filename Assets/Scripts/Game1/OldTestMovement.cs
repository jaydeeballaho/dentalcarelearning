using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldTestMovement : MonoBehaviour {

	void Start(){
		
	}

	void OnMouseDrag() {

		if (PlayerController.paused == false) {
			var point = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, 
				(transform.position.y - Camera.main.transform.position.y)));

			point.z = transform.position.z;
			transform.position = point;
		}

	}

}
