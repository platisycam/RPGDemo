using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EditorMapMenuCtrl : MonoBehaviour {
    bool isExtMenu = false;
    public GameObject subMenu;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ExtendMenu()
    {
        if (isExtMenu)
        {
            subMenu.SetActive(false);
            isExtMenu = false;
        }
        else
        {
            subMenu.SetActive(true);
            isExtMenu = true;
        }

    }

    //返回顶层菜单
    public void ReturnToTopMenu()
    {
        GameObject.Find("Canvas").GetComponent<FloatCtrl>().ShowTopMenu();
        GameObject.Find("Canvas").GetComponent<FloatCtrl>().BtTopMenu.GetComponent<EditorTopMenuCtrl>().ExtendMenu();
    }

    public void ExtLandItemShow() {
    }
}
