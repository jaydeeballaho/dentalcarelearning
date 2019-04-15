using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour {

	float totalTime; //2 minutes

	public int questionNo;
	public int prevQuestion;
	public int scores;
	public int lives;

	public AudioSource BGM;
	public AudioSource Fx;
	public AudioSource correctfx;
	public AudioSource wrongfx;

	int currentOption;
	public Animator CorAnim;
	public Animator WroAnim;

	public Text score;
	public Text live;
	public Text timer;

	public GameObject Winner;

	public GameObject anesthesia;
	public GameObject clippers;
	public GameObject cotton;
	public GameObject floss;
	public GameObject dlight;
	public GameObject pliers;
	public GameObject forceps;
	public GameObject gloves;
	public GameObject mask;
	public GameObject medicines;
	public GameObject mirror;
	public GameObject mouthwash;
	public GameObject paste;
	public GameObject scalpel;
	public GameObject syringe;
	public GameObject tbrush;
	public GameObject tpaste;
	public GameObject polisher;
	public GameObject tray;
	public GameObject tweezers;

	public GameObject[] options;
	public Text[] optionText;

	public GameObject Correctoption;
	public Text correctText;

	public Vector2[] ButtonPos;
	int currentButton;

	public string[] dentals;

	public void CorrectPress(){		//wrong press display wrong
		scores = scores + 5;
		score.text = "Score: " + scores.ToString ();
		CorAnim.Play ("CorrectAnim");
		questionNo = getQuestion(prevQuestion);
		prevQuestion = questionNo;
		correctfx.Play ();
		play ();
	
	}
	int getOption(string a){
		int i = Random.Range (0, 19);
		while(dentals[i]==a){
			i = Random.Range (0, 19);
		}
		return i;
	}
	public void WrongPress(){		//correct press display correct
		lives = lives - 1;
		live.text = "Lives: " + lives.ToString () + "x";
		WroAnim.Play ("WrongAnim");
		wrongfx.Play ();
		if (lives == 0) {
			Winner.SetActive (true);
		}
	}

	public void play(){
		if (questionNo == 0) {
			anesthesia.SetActive (true);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Anesthesia";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		} else if (questionNo == 1) {
			anesthesia.SetActive (false);
			clippers.SetActive (true);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Clippers";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 2) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (true);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Cotton";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 3) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (true);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Dental Floss";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 4) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (true);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Dental Light";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 5) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (true);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Pliers";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 6) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (true);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Forceps";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 7) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (true);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Gloves";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 8) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (true);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Mask";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 9) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (true);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Medicines";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 10) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (true);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Mouth Mirror";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 11) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (true);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Mouthwash";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 12) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (true);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Polishing Paste";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 13) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (true);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Scalpel";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 14) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (true);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Syringe";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 15) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (true);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Tooth Brush";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 16) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (true);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Tooth Paste";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 17) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (true);
			tray.SetActive (false);
			tweezers.SetActive (false);

			correctText.text = "Polisher";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 18) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (true);
			tweezers.SetActive (false);

			correctText.text = "Tray";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}else if (questionNo == 19) {
			anesthesia.SetActive (false);
			clippers.SetActive (false);
			cotton.SetActive (false);
			floss.SetActive (false);
			dlight.SetActive (false);
			pliers.SetActive (false);
			forceps.SetActive (false);
			gloves.SetActive (false);
			mask.SetActive (false);
			medicines.SetActive (false);
			mirror.SetActive (false);
			mouthwash.SetActive (false);
			paste.SetActive (false);
			scalpel.SetActive (false);
			syringe.SetActive (false);
			tbrush.SetActive (false);
			tpaste.SetActive (false);
			polisher.SetActive (false);
			tray.SetActive (false);
			tweezers.SetActive (true);

			correctText.text = "Tweezers";
			currentButton = Random.Range (0, 3);
			Correctoption.transform.localPosition = ButtonPos [currentButton];
			int i = 0;
			int j = 0;
			while (i < 4) {
				if (i != currentButton) {
					options [j].transform.localPosition = ButtonPos [i];
					optionText [j].text = dentals [getOption(correctText.text)];
					j++;
				}
				i++;
			}
		}
	}

	public int getQuestion(int a)
	{
		int i;
		i = Random.Range (0, 19);
		while(i==a){
			i = Random.Range (0, 19);
		}
		return i;
	}

	void Awake()
	{
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
			correctfx.mute = true;
			wrongfx.mute = true;
		} 
		else 
		{
			Fx.mute = false;
			correctfx.mute = false;
			wrongfx.mute = false;
		}
	}

	void Start () {
		Winner.SetActive (false);
		totalTime = 120f;
		prevQuestion = Random.Range(0, 19);
		scores = 0;
		lives = 3;
		questionNo = getQuestion(prevQuestion);
		Time.timeScale = 1;
		play ();
		
	}
	
	// Update is called once per frame
	void Update () {
		totalTime -= Time.deltaTime;
		UpdateLevelTimer(totalTime );
		if ( totalTime <= 0 )
		{
			Winner.SetActive (true);

			totalTime = 0;
		}
	}
	public void UpdateLevelTimer(float totalSeconds)
	{
		int minutes = Mathf.FloorToInt(totalSeconds / 60f);
		int seconds = Mathf.RoundToInt(totalSeconds % 60f);

		//string formatedSeconds = seconds.ToString();

		if (seconds == 60)
		{
			seconds = 0;
			minutes += 1;
		}
		timer.text = "Time: " + minutes.ToString("00") + ":" + seconds.ToString("00");
	}



}
