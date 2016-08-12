using UnityEngine;
using System.Collections;
using System;
using TouchScript.Behaviors;
using TouchScript.Gestures;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

	void OnEnable(){
		GetComponent<PressGesture> ().Pressed += ResetLevel;
	}

	void OnDisable(){
		GetComponent<PressGesture> ().Pressed -= ResetLevel;
	}

	void ResetLevel(object sender, EventArgs e){
		int i = UnityEngine.Random.Range (0, 3);
		switch (i) {
		case 0: 
			SceneManager.LoadScene ("Alpha_Blocks");
			break;
		case 1: 
			SceneManager.LoadScene ("Bat");
			break;
		case 2: 
			SceneManager.LoadScene ("pig_scene");
			break;
		default:
			SceneManager.LoadScene ("Alpha_Blocks");
			break;
		}
	}

}
