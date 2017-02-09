using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewCtrl : MonoBehaviour {
    float scrollSpeed = 0.5f;
    float dragSpeel = 0.5f;
    float maxCamSize = 12f;
    float minCamSize = 1f;
    GameObject systemObject;
    Vector3 prePoint = Vector3.zero;
    Vector3 preCamPoint = Vector3.zero;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        //鼠标滚轮事件
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (Camera.main.orthographicSize < maxCamSize)
            {
                Camera.main.orthographicSize += scrollSpeed;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (Camera.main.orthographicSize > minCamSize)
            {
                Camera.main.orthographicSize -= scrollSpeed;
            }
        }
    }
}
