using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjects : MonoBehaviour {

	public Sprite[] sprites;
	public Vector2 colliderOffset = Vector2.zero;

	private SpriteRenderer render2d;

	// Use this for initialization
	void Start () {
		render2d = GetComponent<SpriteRenderer> ();
		render2d.sprite = sprites [Random.Range (0, sprites.Length)];

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnBecameInvisible () {
		Destroy (gameObject);
	}

}
