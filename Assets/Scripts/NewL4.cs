using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewL4 : GenericWindow {

	public GameObject[] c;

	// Use this for initialization
	void Start () {
		for (int i=0;i<5;i++){
			c[i].gameObject.SetActive(false);
		}
		c[0].gameObject.SetActive(true);
	}
	public void Yes(){
		manager.Open (5);
	}
	public void Close(){
		manager.Open (0);
		for (int i=0;i<5;i++){
			c[i].gameObject.SetActive(false);
		}
		c[0].gameObject.SetActive(true);
	}
	public void Next1(){
		for (int i=0;i<5;i++){
			c[i].gameObject.SetActive(false);
		}
		c[1].gameObject.SetActive(true);
	}
	public void Next2(){
		for (int i=0;i<5;i++){
			c[i].gameObject.SetActive(false);
		}
		c[2].gameObject.SetActive(true);
	}
	public void Next3(){
		for (int i=0;i<5;i++){
			c[i].gameObject.SetActive(false);
		}
		c[3].gameObject.SetActive(true);
	}
	public void Prev3(){
		for (int i=0;i<5;i++){
			c[i].gameObject.SetActive(false);
		}
		c[1].gameObject.SetActive(true);
	}
	public void Next4(){
		for (int i=0;i<5;i++){
			c[i].gameObject.SetActive(false);
		}
		c[4].gameObject.SetActive(true);
	}
	public void Prev4(){
		for (int i=0;i<5;i++){
			c[i].gameObject.SetActive(false);
		}
		c[2].gameObject.SetActive(true);
	}
	// Update is called once per frame
	void Update () {
	}
}
