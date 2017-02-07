using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;
using System;

public class UIDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
    Vector3 offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }



    public void OnBeginDrag(PointerEventData eventData)
    {
        GetOffset();
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition + offset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }

    private void GetOffset() {
        offset = this.transform.position - Input.mousePosition;
    }
}
