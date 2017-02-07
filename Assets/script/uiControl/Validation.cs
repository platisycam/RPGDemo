using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Validation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void FiledClick(string str)
    {
        int n;
        int.TryParse(str, out n);
        if (n <= 0)
        {
            this.GetComponent<InputField>().text = "1";
        } else if (n > 100) {
            this.GetComponent<InputField>().text = "100";
        }
    }
}
