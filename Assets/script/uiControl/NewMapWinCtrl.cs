using System.Collections;
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
        int length;
        int highth;
        int.TryParse(LengthInput.text, out length);
        int.TryParse(HighthInput.text, out highth);
        GameObject.Find("Canvas").GetComponent<FloatCtrl>().ShowEditorMenu();
        GameObject.Find("UnityObject").GetComponent<CreateMapAction>().CreateMap(length, highth);
        this.gameObject.SetActive(false);
    }
}
