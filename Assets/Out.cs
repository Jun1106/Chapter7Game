﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Out : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
