using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMapAction : MonoBehaviour {
    public GameObject prefab;
    GameObject baseItem;
    GameObject map;
    float mapLength;
    float mapHighth;
    Vector3 itemSize;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CreateMap(int length, int highth) {
        //创建地图元素的副本，计算地图所需的大小位置

        if (prefab)
        {
            baseItem = Instantiate(prefab);
        }

        baseItem.AddComponent<BoxCollider2D>();
        itemSize = baseItem.GetComponent<BoxCollider2D>().size;
        Destroy(baseItem);
        map = new GameObject();
        for (int y = 0; y < highth; y++) {
            for (int x = 0; x < length; x++) {
                CreateBaseItem(prefab, x, y);
            }
        }
    }

    private void CreateBaseItem(GameObject prefab, int x, int y) {
        float coX = itemSize.x * (x + 0.5f);
        float coY = itemSize.y * (y + 0.5f);
        GameObject item = Instantiate(prefab, new Vector3(coX, coY, 0f), Quaternion.identity, map.transform);
        item.AddComponent<MapProterty>();
        item.GetComponent<MapProterty>().CoX = coX;
        item.GetComponent<MapProterty>().CoY = coY;
        item.GetComponent<MapProterty>().X = x;
        item.GetComponent<MapProterty>().Y =y;
        Debug.Log("~~~~~~~~~~~~~~~~~~~~~~");
        item.GetComponent<MapProterty>().PrintProterty();
        Debug.Log("~~~~~~~~~~~~~~~~~~~~~~");
    }
}
