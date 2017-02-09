using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapProterty : MonoBehaviour{
    private int x;
    private int y;
    private float coX;
    private float coY;
    private GameObject item;

    public void PrintProterty() {
        Debug.Log("x: " + x + ", y: " + y + ", coX: " + coX + ", coY: " + coY);
    }

    public int X
    {
        get
        {
            return x;
        }

        set
        {
            x = value;
        }
    }

    public int Y
    {
        get
        {
            return y;
        }

        set
        {
            y = value;
        }
    }

    public float CoX
    {
        get
        {
            return coX;
        }

        set
        {
            coX = value;
        }
    }

    public float CoY
    {
        get
        {
            return coY;
        }

        set
        {
            coY = value;
        }
    }

    public GameObject Item
    {
        get
        {
            return item;
        }

        set
        {
            item = value;
        }
    }
}
