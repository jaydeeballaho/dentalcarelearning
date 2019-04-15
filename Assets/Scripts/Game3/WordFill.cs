using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WordFill : MonoBehaviour {

	public Randomizer Randomizer;



	public GameObject WordFiller;
	public GameObject WordClick;
	public GameObject[] newItem;

	public Transform[] Letter = new Transform[17];

	string[] LetChar = new string[26]{"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

	public static string[] bmWord = new string[30]{"ANESTHESIA","DENTISTRY","DENTIST","TEETH","GUMS","CAVITY","BITE","CALCIUM","DECAY","CLEANING","GLOVES","BRUSHING","MEDICINES","MOLAR","ORALHYGIENE","ORTHODENTIST","TARTAR","WHITENING","WISDOMTEETH","TOOTHLOSS","FILLING","COTTON","PLAQUE","PERMANENTTEETH","FLOURIDE","TWEEZERS","MOUTHMIRROR","SYRINGE","MASK","DENTALSTOOL"};

	public int strl;
	public int counter;
	public int[] aFill;

	public char[] aStr;

	public string[] LetterHolder;
	public int[] idx;

	//Fill random letters from A-Z in the teeth.
	public void fill()
	{
		for (int i = 0; i < 15; i++) 
		{
			string RandomLetter = "";
			RandomLetter = LetChar [Random.Range (0, 25)];
			Letter [i].GetComponent<TextMesh> ().text = RandomLetter;
			//LetterHolder [i] = RandomLetter;
			//Debug.Log (System.Array.IndexOf(LetterHolder,RandomLetter));
		}

	}


	public void GenFill()
	{
	//innitialize variables.
		strl = bmWord[Randomizer.Level-1].Length;

		//randomize value, how manny letters in a word to be missing.
		if (strl <= 4) {
			counter = Random.Range (2, 3);
		} else {
			counter = Random.Range (2,5);
		}

		aFill = new int[counter];

		idx = new int[counter];
		LetterHolder = new string[counter];

		aStr = new char[strl];
		aStr = bmWord [Randomizer.Level-1].ToCharArray ();

		newItem = new GameObject[strl];

		Debug.Log ("Takes :"+counter);

		//random positions of missing letters based on counter value.
		for (int i = 0; i < counter ; i++)
		{
			
			aFill [i] = Random.Range (0, strl - 1);
			int z = 1;
			while (i>0 && z>0)
				{
					z = 0;
					for(int j=0;j<i;j++)
					{
						if (aFill [i] == aFill [j]) 
						{
							z++;
						}
					}
						if (z > 0) 
						{
							aFill [i] = Random.Range (0, strl - 1);
						}
				}
		}

		//sort position picked
		for(int x = 0 ; x < counter ;x++)
		{
			
			int temp=0;
			for (int y = 0 ;y < counter-1 ; y++) {

				if (aFill [y] > aFill [y + 1]) 
				{
					temp = aFill [y];
					aFill [y] = aFill [y + 1];
					aFill [y + 1] = temp;
				}
			}
		}

	
		//Generate/instantiate prefab that will display the word with missing letters.
		for(int y = 0; y < strl ; y++)
		{
			//Debug.Log (aStr [y]);
			int checker = 0;

			//check if the position is the picked to be empty.
			for (int z = 0; z < counter ; z++)
			{
				
				if (y == aFill [z]) 
				{
					checker++;
				}

			}

			// Generate Textmesh with the letter of the given word.
			if (checker == 0) 
			{
				newItem [y] = Instantiate (WordFiller,transform.position,Quaternion.identity) as GameObject;
				newItem [y].GetComponent<TextMesh> ().text = aStr [y].ToString();  
				newItem [y].transform.SetParent (gameObject.transform);

			}
			//Generate a clickable empty Textmesh. 
			else 
			{
				newItem [y] = Instantiate (WordClick,transform.position,Quaternion.identity) as GameObject;
				newItem [y].transform.SetParent (gameObject.transform);
			}
		}
	}

	public void refill ()
	{
		int[] filler = new int[counter];
		int a;

		//Randomly pick a position on the teeth to fill with the missing letter of the word.
		for (int l = 0; l < counter; l++) 
		{
			a = Random.Range (0,14);
			int b=1;
			filler [l] = a;

			while (l > 0 && b > 0) 
			{
				b = 0;
				for (int m = 0; m < l; m++) 
				{
					if (filler [l] == filler [m]) 
					{
						b++;
					}

				}
				if (b > 0) 
				{
					filler [l] = Random.Range (0, 14);
				}
			}
		}
		for (int n = 0; n < counter; n++) 
		{
			Letter [filler[n]].GetComponent<TextMesh> ().text = "" + aStr[aFill [n]];
			Debug.Log ("Letter ("+filler[n]+") = "+aStr[aFill [n]]);
		}

	}
		
		
	void Start()
	{
		fill ();
		GenFill ();
		refill ();
	}
		
}
