using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	//for ui panels
	public AudioSource BGM;
	public AudioSource Fx;
	public AudioSource Fx1;
	public AudioSource Fx2;
	public GameObject gamePausedPanel;
	public GameObject gameOverPanel;
	public GameObject saveHighScorePanel;
	public GameObject restartGamePanel;
	public GameObject highScoreListPanel;

	public Spawner[] spawnObj;

	//ui objects under gameOverPanel
	public Text gameOverCurrentScore;

	//ui objects under saveHighScorePanel
	public Text gameOverHighScore;
	public Text DispHScore;
	public InputField playerNameField;
	public Button saveButton;

	//ui objects under main ui
	public Text scoreText;
	public Text lifeText;
	public Text timerText;
	public float totalTime;

	//ui objects under highScoreListPanel
	public Text[] displayNames;
	public Text[] displayeScores;

	//for increasing speed certain time
	public Vector2 velCounter = Vector2.zero;
	public float timeInterval = 10f;
	public float intervalMultiplier = 10f;

	//for saving playerName and Score
	//private int[] highScores = new int[3];
	private string highScoreKey;
	private int highScore;
	//private string[] playerNames = new string[3];
	private string playerNameKey;
	private string playerName;

	//for player
	private PlayerController player;

	//Delay Adding

	void Awake () {	
		//PlayerPrefs.DeleteAll ();

		for (int i = 0; i < 3; i++) {
			highScoreKey = "HighScore" + (i + 1).ToString ();
			highScore = PlayerPrefs.GetInt (highScoreKey, 0);

			playerNameKey = "PlayerName" + (i + 1).ToString ();
			playerName = PlayerPrefs.GetString (playerNameKey, "");

			Debug.Log (playerName+": "+highScore); 
		}

		//-----------------------------------------------------

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
		} 
		else 
		{
			Fx.mute = false;	
			Fx1.mute = false;	
			Fx2.mute = false;	
		}
	}
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();
		Time.timeScale = 1;
		PlayerController.paused = false;
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + player.score.ToString ();
		Debug.Log (player.lives.ToString ());
		lifeText.text = "Lives: " + player.lives.ToString () + "x";
		GameOver ();
	}

	void FixedUpdate(){
		IncreaseSpeedPerMins ();
		timerText.text = Mathf.Round (totalTime).ToString ();
	}
	void GameOver () {
		if (player.lives == 0) {
			Time.timeScale = 0;
			PlayerController.paused = true;
			SetGameOverPanel ();
			BGM.Stop ();
		}
	}

	void IncreaseSpeedPerMins () {
		totalTime += Time.deltaTime;
		if (totalTime >= timeInterval) {
			foreach (Spawner value in spawnObj) {
				value.fallingSpeed += velCounter;
			}
			timeInterval += intervalMultiplier;
		}

	}

	void SetGameOverPanel () {
		for (int i = 0; i < 3; i++) {
			highScoreKey = "HighScore" + (i + 1).ToString ();
			highScore = PlayerPrefs.GetInt (highScoreKey, 0);

			playerNameKey = "PlayerName" + (i + 1).ToString ();
			playerName = PlayerPrefs.GetString (playerNameKey, "");
			Debug.Log (player.score.ToString());
			if (player.score < highScore) {
				gameOverPanel.SetActive (true);
				gameOverCurrentScore.text = "" + player.score.ToString ();
				DispHScore.text = "" + PlayerPrefs.GetInt ("HighScore" + 1);
			} else {
				saveHighScorePanel.SetActive (true);
				gameOverHighScore.text = "" + player.score.ToString ();
			}

		}
	}

	void DisplayHighScores () {
		
		for (int i = 0; i < 3; i++) {
			highScoreKey = "HighScore" + (i + 1).ToString ();
			highScore = PlayerPrefs.GetInt (highScoreKey, 0);
			displayeScores [i].text = highScore.ToString ();

			playerNameKey = "PlayerName" + (i + 1).ToString ();
			playerName = PlayerPrefs.GetString (playerNameKey, "");
			displayNames [i].text = playerName.ToString ();
		}

	}

	public void Pause () {
		Time.timeScale = 0;
		PlayerController.paused = true;
		gamePausedPanel.SetActive (true);
	}

	public void Reload (string scene) {
		SceneManager.LoadScene ("Game1");
	    PlayerController.paused = false;
	}

	public void Home (string scene) {
		SceneManager.LoadScene (0);
	}

	public void NextWindow (string scene) {
		SceneManager.LoadScene ("PlayWindow");
	}

	public void Resume () {
		Time.timeScale = 1;
		PlayerController.paused = false;
		gamePausedPanel.SetActive (false);
		restartGamePanel.SetActive (false);
	}

	public void ConfirmRestart () {
		restartGamePanel.SetActive (true);
	}

	public void CancelRestart () {
		restartGamePanel.SetActive (false);
	}

	public void OpenHighScoreList () {
		DisplayHighScores ();
		highScoreListPanel.SetActive (true);
	}

	public void CloseHighScoreList () {
		highScoreListPanel.SetActive (false);
	}

	public void SaveScores () {
		string nameholder = playerNameField.text;

		for (int i = 0; i < 3; i++) {
			highScoreKey = "HighScore" + (i + 1).ToString ();
			highScore = PlayerPrefs.GetInt (highScoreKey, 0);

			playerNameKey = "PlayerName" + (i + 1).ToString ();
			playerName = PlayerPrefs.GetString (playerNameKey, "");

			if (player.score > highScore) {
				if (playerNameField.text != "") {
					int temp = highScore;
					PlayerPrefs.SetInt (highScoreKey, player.score);
					player.score = temp;

					string temp2 = playerName;
					PlayerPrefs.SetString (playerNameKey, playerNameField.text);
					playerNameField.text = temp2;

					playerNameField.enabled = false;
					saveButton.gameObject.SetActive(false);
				} else {
					Debug.Log ("NULL"); 
				}
			}

		}

		playerNameField.text = nameholder.ToString ();
			
	}
		
}
