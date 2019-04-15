using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DCLWindow : GenericWindow {

	public void Menu(){
		SceneManager.LoadScene ("MainMenu");
	}
	public void OnNext1(){
		manager.Open (1);
	}
	public void OnNext2(){
		manager.Open (2);
	}
	public void OnNext3(){
		manager.Open (3);
	}
	public void OnNext4(){
		manager.Open (4);
	}
	public void OnNext5(){
		manager.Open (5);
	}
}
