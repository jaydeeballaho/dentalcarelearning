using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lesson3Window : GenericWindow {

	public void Menu(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void OnPrev(){
		manager.Open (2);
	}

	public void OnNext(){
		manager.Open (4);
	}
}
