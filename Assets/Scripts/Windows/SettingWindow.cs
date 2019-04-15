using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingWindow : GenericWindow {

	public Toggle togBGM;
	public Toggle togSFX;

	void Start()
	{
		string BGMholder = PlayerPrefs.GetString("BGM");
		string SFXholder = PlayerPrefs.GetString("SFX");
		if (PlayerPrefs.GetString ("BGM") == "True") 
		{
			togBGM.isOn = false;	
		} 
		else 
		{
			togBGM.isOn = true;
		}

		if (PlayerPrefs.GetString ("SFX") == "True") 
		{
			togSFX.isOn = false;	
		} 
		else 
		{
			togSFX.isOn = true;
		}
		PlayerPrefs.SetString ("BGM", BGMholder);
		PlayerPrefs.SetString ("SFX", SFXholder);
		Debug.Log ("BGM = "+PlayerPrefs.GetString("BGM"));
		Debug.Log ("SFX = "+PlayerPrefs.GetString("SFX"));
		Debug.Log ("------------------------------------------------------------");
	}



	public void Menu(){
		manager.Open (0);
	}

	public void SetBGM()
	{
		if (PlayerPrefs.GetString ("BGM") == "True") 
		{
			PlayerPrefs.SetString ("BGM", "False");
		}
		else 
		{
			PlayerPrefs.SetString ("BGM", "True");
		}
		Debug.Log ("BGM = "+PlayerPrefs.GetString("BGM"));
		Debug.Log ("SFX = "+PlayerPrefs.GetString("SFX"));
		Debug.Log ("------------------------------------------------------------");
	}

	public void SetSFX()
	{
		if (PlayerPrefs.GetString ("SFX") == "True") 
		{
			PlayerPrefs.SetString ("SFX", "False");
		}
		else 
		{
			PlayerPrefs.SetString ("SFX", "True");
		}
		Debug.Log ("BGM = "+PlayerPrefs.GetString("BGM"));
		Debug.Log ("SFX = "+PlayerPrefs.GetString("SFX"));
		Debug.Log ("------------------------------------------------------------");
	}
}
