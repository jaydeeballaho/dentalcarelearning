using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class GenericWindow : MonoBehaviour {

	public static windowManager manager;


	protected EventSystem eventSystem{
		get { return GameObject.Find ("EventSystem").GetComponent<EventSystem> (); } 
	} 
		
	protected void Display (bool value){
		gameObject.SetActive (value);
	}

	public void Open(){
		Display (true);
	}

	public void Close(){
		Display (false);
	}

	void Awake () {
			
		Close ();
	}

}
