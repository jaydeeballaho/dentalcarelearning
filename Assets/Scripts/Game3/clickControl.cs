using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickControl : MonoBehaviour {


	public WordFill WF;
	public Text score;

	public AudioSource CLkz;
	public AudioSource Fullz;
	public AudioSource Wrongfx;
	public GameObject pos;

	public Animator anim;
	public Animator CorAnim;
	public Animator WroAnim;

	public GMscript GMS; 

	//public WaitWhile asa;



	void OnMouseDown ()
	{
		
		int check=0;
		int correct=0;

		Debug.Log (name);
		Debug.Log ("Index Number = "+System.Array.IndexOf(WF.Letter,this.transform));

		int b = 0;

		if (GetComponent<TextMesh> ().text != "") 
		{
			pos.transform.position = new Vector2 (this.transform.position.x, this.transform.position.y);
			//anim.GetComponent<Animator> ();
			anim.Play("BrushAnimation");
			CLkz.Play ();
		}

		for (int a = 0 ; a < WF.counter ; a++)
		{
			if (b == 0) {
				if (WF.newItem [WF.aFill [a]].GetComponent<TextMesh> ().text == "") {
					
					WF.newItem [WF.aFill [a]].GetComponent<TextMesh> ().text = "" + GetComponent<TextMesh> ().text;

					WF.idx [a] = System.Array.IndexOf (WF.Letter, this.transform);
					WF.LetterHolder [a] = GetComponent<TextMesh> ().text;

					GetComponent<TextMesh> ().text = "";

					GetComponent<Image> ().enabled = false;
					b++;
				}
			
			}
			if (WF.newItem [WF.aFill [a]].GetComponent<TextMesh> ().text != "") 
			{
				check++;
			}
		}



		if (check == WF.counter) {
			
			for (int c = 0; c < WF.counter; c++) {
				if (WF.newItem [WF.aFill [c]].GetComponent<TextMesh> ().text == "" + WF.aStr [WF.aFill [c]]) {
					correct++;	
				}
				Debug.Log ((c + 1) + " from index =" + WF.idx [c]);
			}

			if (correct == WF.counter) {
				CorAnim.Play ("CorrectAnim");
				Fullz.Play ();
				GMS.points = GMS.points + 5;
				score.text = "Score: " + GMS.points;
				for (int d = 0; d < WF.strl; d++) {
					Destroy (WF.newItem [d]);
				}
				GMS.Nextlvl ();
			} 
			else 
			{
				WroAnim.Play ("WrongAnim");
				Wrongfx.Play ();
				for (int d = 0; d < WF.strl; d++) {
					Destroy (WF.newItem [d]);
				}
				GMS.Nextlvl ();
			}
		}

	}

	void update()
	{

	}

}
