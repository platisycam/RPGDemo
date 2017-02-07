using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorMapMenuCtrl : MonoBehaviour {
    bool isExtMenu = false;
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
            isExtMenu = false;
        }
        else
        {
            isExtMenu = true;
        }

    }
}
