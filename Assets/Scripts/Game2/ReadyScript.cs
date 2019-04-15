using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyScript : MonoBehaviour {

	public GameObject GCanvas;
	public GameObject RCanvas;
	public AudioSource BGM;

	public void StartButton()
	{
		GCanvas.SetActive (true);
		RCanvas.SetActive (false);
		BGM.Play ();
	}

}
