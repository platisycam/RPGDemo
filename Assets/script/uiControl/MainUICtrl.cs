﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUICtrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ExitGame() {
        Application.Quit();
    }

    public void LoadEditor() {
        SceneManager.LoadScene("EditorScene");
    } 

    public void CreateNewGame() {

    }

    public void LodaGame() {

    }
}
