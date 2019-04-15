using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Randomizer : MonoBehaviour {

	public int Level;

	public GameObject Gamepanel;
	public GameObject Stage;
	public Animator br;

	public AudioSource BGM;
	public AudioSource Fx;
	public AudioSource Fx1;
	public AudioSource Fx2;
	public AudioSource Fx3;


	public void randomlvl ()
	{
		Level = Random.Range (1, 30);
	}

	public void begin()
	{
		Gamepanel.gameObject.SetActive(true);
		Stage.SetActive (true);
		gameObject.SetActive (false);
	}

	void Awake(){
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
			Fx1.mute = true;
			Fx2.mute = true;
			Fx3.mute = true;

		} 
		else 
		{
			Fx.mute = false;
			Fx1.mute = false;
			Fx2.mute = false;
			Fx3.mute = false;
		}

		randomlvl ();
	}
		


}
