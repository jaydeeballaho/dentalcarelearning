using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BrushMe : MonoBehaviour {

	public Randomizer _Randomizer;



	int index = 1;

	private char charholder;

	public Text Desc;

	public void outRdz(){
		index = _Randomizer.Level;

	}


	public void LevelDesc(){
		if (index == 1) 
		{
			Desc.text = ("A state of temporary induced loss of sensation and awareness.");

		}

		else if (index == 2) 
		{
			Desc.text = ("Is a branch of medicine.");

		}

		else if (index == 3) 
		{
			Desc.text = ("Also known as a dental surgeon.");

		}
			
		else if (index == 4) 
		{
			Desc.text = ("Are the hardest substance in human body.");

		}			

		else if (index == 5) 
		{
			Desc.text = ("The pink fleshy part of the mouth that surrounds and supports the teeth.");

		}			

		else if (index == 6) 
		{
			Desc.text = ("Decay in teeth caused by candy.");
		}			

		else if (index == 7) 
		{
			Desc.text = ("Relationship of the uppers and lower teeth upon closure.");
		}			

		else if (index == 8) 
		{
			Desc.text = ("The natural element needed for healthy teeth.");
		}			

		else if (index == 9) 
		{
			Desc.text = ("Destruction of tooth structure caused by toxins produced by bacteria.");
		}			

		else if (index == 10) 
		{
			Desc.text = ("Removal of plaque and calculus from teeth.");
		}			

		else if (index == 11) 
		{
			Desc.text = ("Worn to protect against blood and other fluid.");
		}			

		else if (index == 12) 
		{
			Desc.text = ("Is the act of scrubbing teeth.");
		}			

		else if (index == 13) 
		{
			Desc.text = ("Encompasses a variety of health care.");
		}			

		else if (index == 14) 
		{
			Desc.text = ("The back teeth are designed for grinding food.");
		}			

		else if (index == 15) 
		{
			Desc.text = ("The process of maintaining cleanliness of the teeth.");
		}			

		else if (index == 16) 
		{
			Desc.text = ("A dentist who specializes in orthodontics.");
		}			

		else if (index == 17) 
		{
			Desc.text = ("The calcified plaque that forms from mineral salt.");
		}			

		else if (index == 18) 
		{
			Desc.text = ("Causing the teeth to appear brighter.");
		}			

		else if (index == 19) 
		{
			Desc.text = ("The third set of molars.");
		}			

		else if (index == 20) 
		{
			Desc.text = ("One or more teeth fall out or extracted.");
		}			

		else if (index == 21) 
		{
			Desc.text = ("A substance used to patch up tooth.");
		}			

		else if (index == 22) 
		{
			Desc.text = ("is a soft, fluffy staple fiber.");
		}			

		else if (index == 23) 
		{
			Desc.text = ("A sticky, slimy coating that develops on teeth.");
		}			

		else if (index == 24) 
		{
			Desc.text = ("Shows up once the baby teeth fall out.");
		}			

		else if (index == 25) 
		{
			Desc.text = ("A mineral that helps teeth stay strong.");
		}			

		else if (index == 26) 
		{
			Desc.text = ("Small tools used for picking up teeth.");
		}			

		else if (index == 27) 
		{
			Desc.text = ("Known as dentist mirror is an instrument used in dentistry.");
		}			

		else if (index == 28) 
		{
			Desc.text = ("Small tube with a thin hollow needle at the end.");
		}			

		else if (index == 29) 
		{
			Desc.text = ("Intended to be worn health professionals.");
		}			

		else if (index == 30) 
		{
			Desc.text = ("An important piece of equipment in a dental practice.");
		}


			
	}

	void Start()
	{	
		outRdz ();
		LevelDesc ();
	}


}
