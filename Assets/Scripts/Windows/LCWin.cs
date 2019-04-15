using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LCWin : GenericWindow {

	public void Menu(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void OnPlay(){
		PlayerPrefs.SetInt ("FirstTime", 5);
		SceneManager.LoadScene ("PlayWindow");
	}

	public void OnPrev(){
		manager.Open (8);
	}
}
