using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayGamesWindow : GenericWindow{


	public GameObject G1Panel;
	public GameObject G1Ins;
	public GameObject G1Score;
	public GameObject G2Panel;
	public GameObject G2Ins;
	public GameObject G2Score;
	public GameObject G3Panel;
	public GameObject G3Ins;
	public GameObject G3Score;
	public GameObject NMRL;
	public GameObject BMWL;
	public Animator Lock1;
	public Animator Lock2;
	public Animator Unlock;
	public Text NMRLText;
	public Text BWMLText;

	//for saving playerName and Score
	//private int[] highScores = new int[3];
	private string highScoreKey;
	private int highScore;
	//private string[] playerNames = new string[3];
	private string playerNameKey;
	private string playerName;

	//ui objects under highScoreListPanel
	public Text[] displayNames;
	public Text[] displayeScores;

	public Text[] G2displayNames;
	public Text[] G2displayeScores;

	public Text[] G3displayNames;
	public Text[] G3displayeScores;

	public void Menu(){
		G1Panel.SetActive (false);
		G2Panel.SetActive (false);
		G3Panel.SetActive (false);
		SceneManager.LoadScene (0);
	}

	public void WigLock1()
	{
		if (PlayerPrefs.GetInt ("HighScore" + 1) >= 100) 
		{
			Unlock.Play ("UnlockAnim");
			NMRL.SetActive (false);
			PlayerPrefs.SetInt ("NMRUnlock", 1);
		} 
		else 
		{
			Lock1.Play("WiggleLock");
		}

	}
	public void WigLock2()
	{
		if (PlayerPrefs.GetInt ("G2HighScore" + 1) >= 60) 
		{
			Unlock.Play ("UnlockAnim");
			BMWL.SetActive (false);
			PlayerPrefs.SetInt ("BMWUnlock", 1);
		} 
		else 
		{
			Lock2.Play("WiggleLock2");
		}
	}

	//---------------------------------------------Game 1 ---------------------
	public void LoadG1pan(){
		G1Panel.SetActive (true);
	}

	public void LoadG1(){
		SceneManager.LoadScene ("Game1");
	}

	public void G1Back(){
		G1Panel.SetActive (false);
	}

	public void G1Inst()
	{
		G1Ins.SetActive (true);	
	}

	public void G1InstBack()
	{
		G1Ins.SetActive (false);	
	}

	public void G1SB()
	{
		G1Score.SetActive (true);
		DisplayG1HighScores ();
	}

	public void G1SBBack()
	{
		G1Score.SetActive (false);	
	}


	//---------------------------------------------Game 2 ---------------------
	public void LoadG2pan(){
		G2Panel.SetActive (true);
	}

	public void LoadG2(){
		SceneManager.LoadScene ("Game2");
	}

	public void G2Back(){
		G2Panel.SetActive (false);
	}

	public void G2Inst()
	{
		G2Ins.SetActive (true);	
	}

	public void G2InstBack()
	{
		G2Ins.SetActive (false);	
	}

	public void G2SB()
	{
		G2Score.SetActive (true);
		DisplayG2HighScores ();
	}

	public void G2SBBack()
	{
		G2Score.SetActive (false);	
	}


	//------------------------------------------game 3 ---------------------
	public void LoadG3pan(){
		G3Panel.SetActive (true);
	}

	public void LoadG3(){
		SceneManager.LoadScene ("Game3");
	}

	public void G3Back(){
		G3Panel.SetActive (false);
	}

	public void G3Inst()
	{
		G3Ins.SetActive (true);	
	}

	public void G3InstBack()
	{
		G3Ins.SetActive (false);	
	}

	public void G3SB()
	{
		G3Score.SetActive (true);
		DisplayG3HighScores ();
	}

	public void G3SBBack()
	{
		G3Score.SetActive (false);	
	}




	void DisplayG1HighScores () {

		for (int i = 0; i < 3; i++) {
			highScoreKey = "HighScore" + (i + 1).ToString ();
			highScore = PlayerPrefs.GetInt (highScoreKey, 0);
			displayeScores [i].text = highScore.ToString ();

			playerNameKey = "PlayerName" + (i + 1).ToString ();
			playerName = PlayerPrefs.GetString (playerNameKey, "");
			displayNames [i].text = playerName.ToString ();
		}
	}

	void DisplayG2HighScores () {

		for (int i = 0; i < 3; i++) {
			highScoreKey = "G2HighScore" + (i + 1).ToString ();
			highScore = PlayerPrefs.GetInt (highScoreKey, 0);
			G2displayeScores [i].text = highScore.ToString ();

			playerNameKey = "G2PlayerName" + (i + 1).ToString ();
			playerName = PlayerPrefs.GetString (playerNameKey, "");
			G2displayNames [i].text = playerName.ToString ();
		}
	}

	void DisplayG3HighScores () {

		for (int i = 0; i < 3; i++) {
			highScoreKey = "G3HighScore" + (i + 1).ToString ();
			highScore = PlayerPrefs.GetInt (highScoreKey, 0);
			G3displayeScores [i].text = highScore.ToString ();

			playerNameKey = "G3PlayerName" + (i + 1).ToString ();
			playerName = PlayerPrefs.GetString (playerNameKey, "");
			G3displayNames [i].text = playerName.ToString ();
		}
	}



	void Start()
	{
		if (PlayerPrefs.GetInt ("NMRUnlock") > 0) 
		{
			NMRL.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("BMWUnlock") > 0) 
		{
			BMWL.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("HighScore" + 1) >= 100) 
		{
			NMRLText.text = "Press to Unlock";
		}
		if (PlayerPrefs.GetInt ("G2HighScore" + 1) >= 50) 
		{
			BWMLText.text = "Press to Unlock";
		}
	}
}
