using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	 static public float second = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!GoalArea.isGoal) {
			second += Time.deltaTime;
		}

		var time = Mathf.FloorToInt(second);
		var text = GetComponent<Text>();
		text.text = "time:" + time.ToString();
	}
}
