using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewL2 : GenericWindow {

	public Sprite[] img;

	public Button prev;
	public Button next;
	public Button go;

	public AudioSource bip;
	public GameObject c;
	public GameObject c1;

	private int i;

	// Use this for initialization
	void Start () {
		i = 0;
		Intro (i);
	}
	public void Close()
	{
		manager.Open (0);
		i = 0;
		Intro (i);
		c.gameObject.SetActive (true);
		c1.gameObject.SetActive (false);
		prev.gameObject.SetActive (false);
		next.gameObject.SetActive (true);
		go.gameObject.SetActive (false);
	}
	// Update is called once per frame
	public void Intro(int i){
		c.GetComponent<Image> ().sprite = img [i];
	}
	public void Go(){
		c1.SetActive (true);
	}
	public void Yes(){
		manager.Open (3);
	}
	public void Prev(){
		bip.Play ();
		i--;
		Intro (i);
		if (i > 0 && i < 3) {
			prev.gameObject.SetActive (true);
			next.gameObject.SetActive (true);
			go.gameObject.SetActive (false);
		} else {
			prev.gameObject.SetActive (false);
			next.gameObject.SetActive (true);
			go.gameObject.SetActive (false);
		}
	}
	public void Next(){
		bip.Play ();
		i++;
		Intro (i);
		if (i > 0 && i < 3) {
			prev.gameObject.SetActive (true);
			next.gameObject.SetActive (true);
			go.gameObject.SetActive (false);
		} else {
			prev.gameObject.SetActive (true);
			next.gameObject.SetActive (false);
			go.gameObject.SetActive (true);
		}
	}
}
