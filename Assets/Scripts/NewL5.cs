using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewL5 : GenericWindow {

	public GameObject[] c;
	public GameObject g;

	// Use this for initialization
	void Start () {
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[0].gameObject.SetActive(true);
	}
	public void Yes(){
		manager.Open (5);
	}
	public void Close(){
		manager.Open (0);
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[0].gameObject.SetActive(true);
	}
	public void Next1(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[1].gameObject.SetActive(true);
	}
	public void Next2(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[2].gameObject.SetActive(true);
	}
	public void Next3(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[3].gameObject.SetActive(true);
	}
	public void Prev3(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[1].gameObject.SetActive(true);
	}
	public void Next4(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[4].gameObject.SetActive(true);
	}
	public void Prev4(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[2].gameObject.SetActive(true);
	}
	public void Next5(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[5].gameObject.SetActive(true);
	}
	public void Prev5(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[3].gameObject.SetActive(true);
	}
	public void Next6(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[6].gameObject.SetActive(true);
	}
	public void Prev6(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[4].gameObject.SetActive(true);
	}
	public void Next7(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[7].gameObject.SetActive(true);
	}
	public void Prev7(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[5].gameObject.SetActive(true);
	}
	public void Next8(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[8].gameObject.SetActive(true);
	}
	public void Prev8(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[6].gameObject.SetActive(true);
	}
	public void Next9(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[9].gameObject.SetActive(true);
	}
	public void Prev9(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[7].gameObject.SetActive(true);
	}
	public void Next10(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[10].gameObject.SetActive(true);
	}
	public void Prev10(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[8].gameObject.SetActive(true);
	}
	public void Ready(){
		PlayerPrefs.SetInt ("FirstTime", 20);
		SceneManager.LoadScene ("PlayWindow");
	}
	public void Back(){
		for (int i=0;i<11;i++){
			c[i].gameObject.SetActive(false);
		}
		c[9].gameObject.SetActive(true);
	}
	// Update is called once per frame
	void Update () {
	}
}
