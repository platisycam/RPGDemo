using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EditorTopMenuCtrl : MonoBehaviour {
    bool isExtMenu1 = false;
    public GameObject subMenu;
    public GameObject newMapWin;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ExtendMenu() {
        if (isExtMenu1){
            //transform.Find("Menu1").gameObject.SetActive(false);
            subMenu.SetActive(false);
            isExtMenu1 = false;
        }
        else {
            // transform.Find("Menu1").gameObject.SetActive(true);
            subMenu.SetActive(true);
            isExtMenu1 = true;
        }

    }

    public void CreateNewMap() {
        ExtendMenu();
        newMapWin.SetActive(true);
    }

    public void LoadMap() {
    }

    public void SaveMap() {
    }

    public void ReturnToMainMenu() {
        SceneManager.LoadScene("mainMenuScene");
    }
}
