using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lesson7Window : GenericWindow {

	public GameObject Panel;
	public GameObject itemPanel;

	public void Menu(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void OnPrev(){
		manager.Open (7);
	}

	public void OnNext(){
		manager.Open (9);
	}

	public void showPanel(){
	
		Panel.gameObject.SetActive (true);
	}

	public void hidePanel(){

		Panel.gameObject.SetActive (false);
	}

	public void showItemPanel(){

		itemPanel.gameObject.SetActive (true);
	}

	public void hideItemPanel(){

		itemPanel.gameObject.SetActive (false);
	}

}
