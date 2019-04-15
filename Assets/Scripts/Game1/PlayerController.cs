using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public Sprite[] sprites;
	public float speed = 5f;
	public int lives;
	public int score;

	public AudioSource Goodfx;
	public AudioSource Badfx;
	public GameObject PointsPos;
	public Animator Pointsfx;

	public static bool paused = false;

	private int goodObjectPoints = 5;
	private int good2ObjectPoints = 10;

	private Rigidbody2D rBody2D;
	private SpriteRenderer render2D;

	// Use this for initializat	ion
	void Start () {
		lives = 3;
		rBody2D = GetComponent<Rigidbody2D> ();
		render2D = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D (Collision2D fallObj) {
		
		if (fallObj.gameObject.tag == "Good") {

			score += goodObjectPoints;
			render2D.sprite = sprites [1];
			Destroy (fallObj.gameObject);
			//Debug.Log (fallObj.gameObject.tag);
			Goodfx.Play();
			PointsPos.transform.position = new Vector2 (this.transform.position.x, this.transform.position.y+75);
			Pointsfx.gameObject.GetComponent<Text>().text="+5 Points";
			Pointsfx.Play ("PointsAnim");

		} else if (fallObj.gameObject.tag == "Good2") {

			score += good2ObjectPoints;
			render2D.sprite = sprites [1];
			Destroy (fallObj.gameObject);
			//Debug.Log (fallObj.gameObject.tag);
			Goodfx.Play();
			PointsPos.transform.position = new Vector2 (this.transform.position.x, this.transform.position.y+75);
			Pointsfx.gameObject.GetComponent<Text>().text="+10 Points";
			Pointsfx.Play ("PointsAnim");

		} else if (fallObj.gameObject.tag == "Bad") {

			render2D.sprite = sprites [2];
			Destroy (fallObj.gameObject);
			lives = lives - 1;
			//Debug.Log (fallObj.gameObject.tag);
			Badfx.Play();
			PointsPos.transform.position = new Vector2 (this.transform.position.x, this.transform.position.y+75);
			Pointsfx.gameObject.GetComponent<Text>().text="-1 Life";
			Pointsfx.Play ("PointsAnim");

		} else if (fallObj.gameObject.tag == "Life") {
			
			render2D.sprite = sprites [1];
			Destroy (fallObj.gameObject);
			if (lives < 3) {
				lives = lives + 1;
				PointsPos.transform.position = new Vector2 (this.transform.position.x, this.transform.position.y+75);
				Pointsfx.gameObject.GetComponent<Text>().text="+1 Life";
				Pointsfx.Play ("PointsAnim");
			}
			//Debug.Log (fallObj.gameObject.tag); 
			Goodfx.Play();

		}
	}
		
}
