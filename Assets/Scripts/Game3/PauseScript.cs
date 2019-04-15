using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseScript: MonoBehaviour {

	public TimerScript TS;

	public GameObject panel;
	public GameObject RestartPan;
	public GameObject stage;

	public void ButtonPressed()
	{
		stage.SetActive (false);
		panel.SetActive(true);
		TS.enabled = false;

	}

	public void Resume()
	{
		stage.SetActive (true);
		panel.SetActive(false);
		TS.enabled = true;
	}

	public void Restart()
	{
		RestartPan.SetActive (true);
	}

	public void ConfResY(){
		SceneManager.LoadScene ("Game3");
	}

	public void ConfResN(){
		RestartPan.SetActive (false);
	}

	public void ReturnMenu()
	{
		SceneManager.LoadScene(0);
	}
}
