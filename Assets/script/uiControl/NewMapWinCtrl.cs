﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewMapWinCtrl : MonoBehaviour {
    public InputField LengthInput;
    public InputField HighthInput;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CloseWin() {
        this.gameObject.SetActive(false);
    }

    public void CommitWin() {
        GameObject.Find("UnityObject").GetComponent<CreateMapAction>().CreateMap(LengthInput.text, HighthInput.text);
        this.gameObject.SetActive(false);
    }
}
