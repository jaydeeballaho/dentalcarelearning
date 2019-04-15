using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowManager : MonoBehaviour {

	public GenericWindow[] windows;
	public int currentWindowID;
	public int defaultWindowID;
	public AudioSource BGM;
	public AudioSource Fx;
	public AudioSource Fx2;

	public GenericWindow GetWindow(int value){
		return windows [value];
		}

	private void ToggleVisability(int value) {	
		var total = windows.Length;

		for (var i = 0; i< total; i++){
			var window = windows [i];
			if (i == value)
				window.Open ();
			else if (window.gameObject.activeSelf)
				window.Close ();
		}
	}

	public GenericWindow Open (int value){
		if (value < 0 || value >= windows.Length)
			return null;
		currentWindowID = value;

		ToggleVisability (currentWindowID);

		return GetWindow (currentWindowID);
	}

	void Awake()
	{
		
		if(PlayerPrefs.GetString ("BGM")=="")
		{
			PlayerPrefs.SetString("BGM","True");
		}
		if(PlayerPrefs.GetString ("SFX")=="")
		{
			PlayerPrefs.SetString("SFX","True");
		}
	
		//----------------------------------------------------------
		if (PlayerPrefs.GetString ("BGM") == "False") 
		{
			BGM.mute = true;
		} 
		else 
		{
			BGM.mute = false;	
		}

		if (PlayerPrefs.GetString ("SFX") == "False") 
		{
			Fx.mute = true;
			Fx2.mute = true;
		} 
		else 
		{
			Fx.mute = false;	
			Fx2.mute = false;
		}
		Debug.Log ("BGM = "+PlayerPrefs.GetString("BGM"));
		Debug.Log ("SFX = "+PlayerPrefs.GetString("SFX"));
		Debug.Log ("------------------------------------------------------------");
	}

	void Start(){
		GenericWindow.manager = this;
		Open (defaultWindowID);
	}
}
