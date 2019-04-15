using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lesson8Window : GenericWindow {

	public GameObject Panel1;
	public GameObject Panel2;
	public GameObject Panel3;

	public void Menu(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void OnPrev(){
		manager.Open (6);
	}

	public void OnNext(){
		manager.Open (8);
	}

	public void showPanel1(){

		Panel1.gameObject.SetActive (true);
	}

	public void hidePanel1(){

		Panel1.gameObject.SetActive (false);
	}

	public void showPanel2(){

		Panel2.gameObject.SetActive (true);
	}

	public void hidePanel2(){

		Panel2.gameObject.SetActive (false);
	}

	public void showPanel3(){

		Panel3.gameObject.SetActive (true);
	}

	public void hidePanel3(){

		Panel3.gameObject.SetActive (false);
	}
		
}
