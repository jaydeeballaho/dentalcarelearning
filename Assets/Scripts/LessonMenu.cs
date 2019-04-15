using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LessonMenu : MonoBehaviour {

	public GameObject n1;
	public GameObject n11;

	public GameObject n2;
	public GameObject n22;

	public GameObject n3;
	public GameObject n33;

	public GameObject n4;
	public GameObject n44;

	public GameObject n5;
	public GameObject n55;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Lesson1(){
		n1.SetActive (true);
		n11.SetActive (true);
	}
	public void Lesson2(){
		n2.SetActive (true);
		n22.SetActive (true);
	}
	public void Lesson3(){
		n3.SetActive (true);
		n33.SetActive (true);
	}	
	public void Lesson4(){
		n4.SetActive (true);
		n44.SetActive (true);
	}	
	public void Lesson5(){
		n5.SetActive (true);
		n55.SetActive (true);
	}



}
