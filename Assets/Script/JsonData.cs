using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonData : MonoBehaviour
{
    ItemList itemList;
    // Start is called before the first frame update
    void Start()
    {
        
        TextAsset json = Resources.Load<TextAsset>("ItemsList");
        itemList = JsonUtility.FromJson<ItemList>(json.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public string ItemsName(int ID)
    {
        return itemList.ItemEntityList[ID - 1].Name;
    }
    public string ItemsContent(int ID)
    {
        return itemList.ItemEntityList[ID - 1].Description;
    }
    public string ItemsIMG(int ID)
    {
        return itemList.ItemEntityList[ID - 1].IMG;
    }
    public int ItemsBuyPrice(int ID)
    {
        return itemList.ItemEntityList[ID - 1].BuyPrice;
    }
}
