using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {
	bool gameHasEnded = false;
	public float delay =2f;

	public GameObject completeLevelUI;

	public void CompleteLevel(){
		Debug.Log ("Level1Completed");
		completeLevelUI.SetActive (true);
	}
	public void EndGame(){
		if (gameHasEnded == false) {
			gameHasEnded = true;
			Debug.Log ("Game Over");
			Invoke ("Restart", delay);
		}

	}
	void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

}
