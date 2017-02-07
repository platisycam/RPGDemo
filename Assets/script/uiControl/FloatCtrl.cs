using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatCtrl : MonoBehaviour {
    public Button BtEditorMenu;
    public Button BtTopMenu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowTopMenu() {
        BtTopMenu.gameObject.SetActive(true);
        BtEditorMenu.gameObject.SetActive(false);
    }

    public void ShowEditorMenu() {
        BtEditorMenu.gameObject.SetActive(true);
        BtTopMenu.gameObject.SetActive(false);
    }
}
