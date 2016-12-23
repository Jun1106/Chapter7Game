using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameResault : MonoBehaviour {
	int hightScore = 999;
	public Text resaultTime;
	public Text bestTime;
	public GameObject parts;

	// Use this for initialization
	void Start() {
		if (PlayerPrefs.HasKey("highScore")) {
			hightScore = PlayerPrefs.GetInt("highScore");
		}
	}

	// Update is called once per frame
	void Update() {
		if (GoalArea.isGoal) {
			parts.SetActive(true);
			var resault = Mathf.FloorToInt(Timer.second);
			resaultTime.text = "ResaultTime: " + resault.ToString();
			bestTime.text = "BestTime: " + hightScore.ToString();

			if (hightScore > resault) {
				PlayerPrefs.SetInt("highScore", resault);
			}
		}
	}

	public void OnRetry() {
		SceneManager.LoadScene("Main");
	}
}
