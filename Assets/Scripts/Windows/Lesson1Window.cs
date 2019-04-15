using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lesson1Window : GenericWindow {

	public void Menu(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void OnNext(){
		manager.Open (2);
	}

}
