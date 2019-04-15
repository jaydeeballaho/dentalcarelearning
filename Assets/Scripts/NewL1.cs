using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewL1 : GenericWindow {

	public Button next, prev;
	public GameObject c1,c2;
	public Text title;
	public Text des;

	string l1 = "- the hardest substance in the human body and used to break down foods.";
	string l2 =  "- the pinky fleshy part of the mouth that surrounds and support teeth.";
	string l3 = "- are soft, movable, and serve as the opening for food intake.";
	string l4 = "- a damage to the structure of a tooth.";
	string l5 = "- used for tasting, licking and swallowing.";

	public int counter = 1;
	// Use this for initialization
	void Start () {
		setUP ();
	}
	public void setUP(){
		counter = 1;
		getLecture (counter);
		c1.SetActive (true);
		c2.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
		
	}
	public void getLecture(int i){
		if (i == 1) {
			title.text = "Teeth";
			des.text = l1;
		} else if (i == 2) {
			title.text = "Gums";
			des.text = l2;
		}else if (i == 3) {
			title.text = "Lips";
			des.text = l3;
		}else if (i == 4) {
			title.text = "Cavity";
			des.text = l4;
		}else if (i == 5) {
			title.text = "Tongue";
			des.text = l5;
		}
	}
	public void Yes(){
		manager.Open (2);
	}
	public void closeLesson(){
		manager.Open (0);
		setUP ();
	}
	public void nextLecture(){
		if (counter < 6) {
			counter++;
			getLecture (counter);
			if (counter == 6) {
				c1.SetActive (false);
				c2.SetActive (true);
			} else {
				next.enabled = true;
				prev.enabled = true;
			}
		}
	}
	public void prevLecture(){
		if (counter > 1) {
			counter--;
			getLecture (counter);
			if (counter == 1) {
				next.enabled = true;
				prev.enabled = false;
			} else {
				next.enabled = true;
				prev.enabled = true;
			}
		}
	}

}
