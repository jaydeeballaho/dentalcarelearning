using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] prefabs;
	public GameObject lifePrefab;
	public float delay = 2f;
	public bool active = true;
	public Vector2 delayRange = new Vector2 (1, 2);
	public Vector2 fallingSpeed = new Vector2 (0, -400);

	// Use this for initialization
	void Start () {
		ResetDelay ();
		StartCoroutine (objectGenerator ());
	}

	IEnumerator objectGenerator(){
		yield return new WaitForSeconds (delay);
		if (active) {
			var sr = GetComponent<Renderer> ();
			GameObject clone;

			var x1 = transform.position.x - sr.bounds.size.x / 2;
			var x2 = transform.position.x + sr.bounds.size.x / 2;

			var spawnPoint = new Vector2 (Random.Range (x1, x2), transform.position.y);

			var randNum = Random.Range (0, 99);

			if (randNum >= 89) {
				clone =	Instantiate (lifePrefab, spawnPoint, Quaternion.identity) as GameObject;
				Rigidbody2D rbody2d = clone.GetComponent<Rigidbody2D> ();
				rbody2d.velocity = fallingSpeed;
			} else {
				clone = Instantiate (prefabs [Random.Range (0, prefabs.Length)], spawnPoint, Quaternion.Euler(0,0,Random.Range(-40,40))) as GameObject;
				Rigidbody2D rbody2d = clone.GetComponent<Rigidbody2D> ();
				rbody2d.velocity = fallingSpeed;
			}

			ResetDelay ();
		}
		StartCoroutine (objectGenerator ());
	}

	void ResetDelay () {
		delay = Random.Range (delayRange.x, delayRange.y);
	}

}
