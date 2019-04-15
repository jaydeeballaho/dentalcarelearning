using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class G1Ready : MonoBehaviour {

	public GameManager obj;
	public Spawner obj1;
	public GameObject panelReady;
	public Text readyText;
	float time;

	// Use this for initialization
	void Start () {
		panelReady.SetActive (true);
		Time.timeScale = 1;
		time = 5f;
		obj.enabled = false;
		obj1.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		readyText.text = Mathf.Round (time).ToString ();
		time -= Time.deltaTime;
		if (time <= 0) {
			panelReady.SetActive (false);
			obj.enabled = true;
			obj1.enabled = true;
		}
	}
}
