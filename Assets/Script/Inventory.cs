using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class InventoryData
{
    public int ID;
    public int Amount;

    public InventoryData(int id, int amount)
    {
        ID = id;
        Amount = amount;
    }
}

public class Inventory : MonoBehaviour
{
    public GameObject JsonData;
    public BagSystem Bag;
    public GameObject BagBox;
    //public ArrayList BagList = new ArrayList();
    public List<InventoryData> BagList = new List<InventoryData>();
    //public List<int , int> Contents = new List<int, int>();


    // Start is called before the first frame update
    void Awake()
    {
        JsonData = GameObject.Find("JsonData");
        Bag = GameObject.Find("BagBox").GetComponent<BagSystem>();
    }
    void Start()
    {
        AddItem(2, 2);
        AddItem(4, 3);
        AddItem(5, 7);
        AddItem(6, 1);
        AddItem(7, 4);
        AddItem(8, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Refresh()
    {

    }
    public void AddItem(int No,int Number)
    {
        ArrayList Contents = new ArrayList();
        int Stack = 0;
        for (int i = 0; i < BagList.ToArray().Length; i++)
        {
            if(BagList[i].ID == No)
            {
                Stack = 1;
                BagList[i].Amount += Number;
            }
        }
        if(Stack == 0)
        {
            BagList.Add(new InventoryData(No, Number));
        }
       
        string Message = "";
        for (int i = 0; i < BagList.ToArray().Length; i++)
        {
            //Message += BagList[i] + ",";
            Debug.Log("Item:" + BagList[i].ID);
        }
        Debug.Log("Done");
        Bag.Refresh();
    }
    public void DelItem(int No, int Number)
    {
        int Ldata = 0;
        for (int i = 0; i < BagList.ToArray().Length; i++)
        {
            if (BagList[i].ID == No)
            {
                BagList[i].Amount -= Number;
                if(BagList[i].Amount < 1)
                {
                    CloseContent();
                    BagList.RemoveAt(i);
                }
                else
                {
                    Ldata = i;
                    
                }
            }
        }
        Bag.Refresh();
        if(Ldata != 0)
        {
            LoadContent(Ldata);
        }
    }
    public void LoadContent(int ID)
    {
        Bag.LoadContent(BagList[ID].ID, BagList[ID].Amount);
    }
    public void CloseContent()
    {
        Bag.CloseContent();
    }
    public void OpenBox()
    {
        BagBox.SetActive(true);
    }
}
