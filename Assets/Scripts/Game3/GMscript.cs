using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GMscript : MonoBehaviour {

	public Randomizer rand;
	public BrushMe brMe;
	public WordFill Wfill;
	public int points;


	public void Nextlvl (){
		rand.randomlvl ();
		brMe.outRdz ();
		brMe.LevelDesc ();
		Wfill.fill ();
		Wfill.GenFill ();
		Wfill.refill ();
		for (int x = 0 ; x < 15 ; x++){
		Wfill.Letter [x].GetComponent<Image> ().enabled = true;
		}
	}

	public void Restart ()
	{
		points = 0;
		Nextlvl ();
		for (int i = 0; i < 15; i++) {
			Wfill.Letter [i].GetComponent<Image> ().enabled = true;
		}
	}


}
