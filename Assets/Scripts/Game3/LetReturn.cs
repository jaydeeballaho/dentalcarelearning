using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetReturn : MonoBehaviour {

	public WordFill WF;
	public AudioSource Clkz;

	//public int[] idx = new int[WF.counter];
	int key;

	void OnMouseDown()
	{
		if (GetComponent<TextMesh> ().text != "") 
		{
			Clkz.Play ();
			key = System.Array.IndexOf (WF.LetterHolder, "" + GetComponent<TextMesh> ().text);
			WF.LetterHolder [key] = "";
			WF.Letter [WF.idx [key]].GetComponent<TextMesh> ().text = "" + GetComponent<TextMesh> ().text;
			WF.Letter [WF.idx [key]].GetComponent<Image> ().enabled = true;
			GetComponent<TextMesh> ().text = "";
		}
	}


}
