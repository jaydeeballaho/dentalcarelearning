using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GOscipt : MonoBehaviour {

	public GMscript GMscr;
	public Text score;
	public InputField Pname;
	public Button sav;

	public GameObject AltGO;
	public Text newHScore;
	public Text YourScore;
	public Text HighScore;



	private string highScoreKey;
	private int highScore;
	//private string[] playerNames = new string[3];
	private string playerNameKey;
	private string playerName;

	void Start () {
		score.text = ""+GMscr.points;
		SetGameover ();
	}

	public void SetGameover()
	{
		for (int i = 0; i < 3; i++) {
			highScoreKey = "G3HighScore" + (i + 1).ToString ();
			highScore = PlayerPrefs.GetInt (highScoreKey, 0);

			playerNameKey = "G3PlayerName" + (i + 1).ToString ();
			playerName = PlayerPrefs.GetString (playerNameKey, "");

			if (GMscr.points < highScore) {
				AltGO.SetActive (true);
				YourScore.text = "" + GMscr.points.ToString ();
				HighScore.text = "" + PlayerPrefs.GetInt ("G3HighScore" + 1);
			} else {
				newHScore.text = "" + GMscr.points.ToString ();
			}

		}
	}


	public void save()
	{
		string nameholder = Pname.text;

		for (int i = 0; i < 3; i++) {
			highScoreKey = "G3HighScore" + (i + 1).ToString ();
			highScore = PlayerPrefs.GetInt (highScoreKey, 0);

			playerNameKey = "G3PlayerName" + (i + 1).ToString ();
			playerName = PlayerPrefs.GetString (playerNameKey, "");

			if (GMscr.points > highScore) {
				if (Pname.text != "") {
					int temp = highScore;
					PlayerPrefs.SetInt (highScoreKey, GMscr.points);
					GMscr.points = temp;

					string temp2 = playerName;
					PlayerPrefs.SetString (playerNameKey, Pname.text);
					Pname.text = temp2;

					Pname.enabled = false;
					sav.gameObject.SetActive(false);
				} else {
					Debug.Log ("NULL"); 
				}
			}

		}

		Pname.text = nameholder.ToString ();
	}



	public void NextGo()
	{
		SceneManager.LoadScene ("PlayWindow");
	}
	public void HomeGo()
	{
		SceneManager.LoadScene (0);
	}

	public void RestartGo()
	{
		SceneManager.LoadScene ("Game3");
	}
	

}
