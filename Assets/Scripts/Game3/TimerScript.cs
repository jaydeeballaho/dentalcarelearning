using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

	public Text TimerText;

	public GameObject GO;
	public AudioSource BGM1;
	public AudioSource BGM2;

	float totalTime = 120f;
	int minutes=1;
	int seconds=1;

	void Start(){

		totalTime = 120f;
		minutes = 1;
		seconds = 1;
		Time.timeScale = 1;
	}

	private void Update ()
	{
		if (minutes == 0 && seconds == 0) {
			Debug.Log ("Times Up!");
			gameObject.SetActive (false);
			seconds = 30;
			GO.SetActive (true);
			BGM1.Stop ();
			BGM2.Play ();
		} else {

			totalTime -= Time.deltaTime;
			UpdateLevelTimer (totalTime);
		}
	}

	public void UpdateLevelTimer(float totalSeconds)
	{
		minutes = Mathf.FloorToInt (totalSeconds / 60f);
		seconds = Mathf.RoundToInt (totalSeconds % 60f);

			string formatedSeconds = seconds.ToString();

			if (seconds == 60) 
			{
				seconds = 0;
				minutes += 1;
			}

			TimerText.text = "Time: " + minutes.ToString ("00") + ":" + seconds.ToString ("00");
		
	}



}
