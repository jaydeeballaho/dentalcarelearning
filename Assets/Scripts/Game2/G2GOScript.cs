using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class G2GOScript : MonoBehaviour {

	public Question Q;
	public AudioSource BGM;
	public GameObject AltGO;
	public Text newHScore;
	public Text YourScore;
	public Text HighScore;
	public InputField Name;
	public Button Save;


	private string highScoreKey;
	private int highScore;
	//private string[] playerNames = new string[3];
	private string playerNameKey;
	private string playerName;


	void Start () {
		Q.enabled = false;
		BGM.Stop ();
		SetGameover ();
	}

	public void SetGameover()
	{
		for (int i = 0; i < 3; i++) {
			highScoreKey = "G2HighScore" + (i + 1).ToString ();
			highScore = PlayerPrefs.GetInt (highScoreKey, 0);

			playerNameKey = "G2PlayerName" + (i + 1).ToString ();
			playerName = PlayerPrefs.GetString (playerNameKey, "");

			if (Q.scores < highScore) {
				AltGO.SetActive (true);
				YourScore.text = "" + Q.scores.ToString ();
				HighScore.text = "" + PlayerPrefs.GetInt ("G2HighScore" + 1);
			} else {
				newHScore.text = "" + Q.scores.ToString ();
			}

		}
	}


	public void SaveScores () {
		string nameholder = Name.text;

		for (int i = 0; i < 3; i++) {
			highScoreKey = "G2HighScore" + (i + 1).ToString ();
			highScore = PlayerPrefs.GetInt (highScoreKey, 0);

			playerNameKey = "G2PlayerName" + (i + 1).ToString ();
			playerName = PlayerPrefs.GetString (playerNameKey, "");

			if (Q.scores > highScore) {
				if (Name.text != "") {
					
					int temp = highScore;
					PlayerPrefs.SetInt (highScoreKey, Q.scores);
					Q.scores = temp;

					string temp2 = playerName;
					PlayerPrefs.SetString (playerNameKey, Name.text);
					Name.text = temp2;

					Name.enabled = false;
					Save.gameObject.SetActive(false);
				} else {
					Debug.Log ("NULL"); 
				}
			}

		}

		Name.text = nameholder.ToString();
		//SceneManager.LoadScene ("Gamewindows");


	}


	public void GoNext(){
		SceneManager.LoadScene ("PlayWindow");
	}
	public void GoRestart(){
		SceneManager.LoadScene ("Game2");
	}

	public void GoHome(){
		SceneManager.LoadScene (0);
	}



	void Update () {
		
	}
}
