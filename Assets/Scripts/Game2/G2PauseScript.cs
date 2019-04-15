using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class G2PauseScript : MonoBehaviour {


	public Question Q;
	public GameObject Pausedpan;
	public GameObject RestPan;


	public void PauseGame()
	{
		Pausedpan.SetActive (true);
		Q.enabled = false;

	}

	public void ResumeGame()
	{
		Pausedpan.SetActive (false);
		Q.enabled = true;
	}

	public void RestartPan()
	{
		RestPan.SetActive (true);
	}

	public void RestConfY()
	{
		SceneManager.LoadScene ("Game2");
	}

	public void RestConfN()
	{
		RestPan.SetActive (false);
	}

	public void HomeGo()
	{
		SceneManager.LoadScene (0);
	}
}
