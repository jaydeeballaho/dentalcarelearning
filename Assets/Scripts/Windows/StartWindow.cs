using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartWindow : GenericWindow {

	public GameObject ExitPan;
	//public GameObject InfoPan;

	public void PlayGames(){
		Debug.Log (PlayerPrefs.GetInt ("FirstTime"));
		if (PlayerPrefs.GetInt ("FirstTime") == 20) {
			SceneManager.LoadScene ("PlayWindow");
		} else {
			manager.Open(3);
		}
	}

	public void DCL(){
	//	PlayerPrefs.SetInt ("FirstTime", 1);
		SceneManager.LoadScene ("DCLWindow");
	}
	public void Settings(){
		manager.Open(1);
	}

	public void Credits(){
		manager.Open(2);
	}
		
	public void Exit(){
		ExitPan.SetActive (true);
	}

	public void ExitYes()
	{
		Application.Quit ();
	}

	public void ExitNo()
	{
		ExitPan.SetActive (false);

	}
}
