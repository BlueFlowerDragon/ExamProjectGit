using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BagSystem : MonoBehaviour
{
    public GameObject Box;
    public GameObject GroupList;
    public GameObject Inventory;
    public GameObject Self;
    public GameObject ContentBox;
    public JsonData JsonData;
    public int LoadBox = -1;
    public GameObject IMG;
    public Text Amounttext;
    public Text Nametext;
    public Text Contenttext;

    public bool frist;
    public bool MouseDown = false;
    public float autouse = 0f;
    // Start is called before the first frame update
    void Awake()
    {
        Inventory = GameObject.Find("PlayerInventory");
        JsonData = GameObject.Find("JsonData").GetComponent<JsonData>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MouseDown)
        {
            autouse += Time.deltaTime;
            if(autouse >= 2f)
            {
                autouse -= 2f;
                Eve2S();
            }
        }
    }

    public void CloseContent()
    {
        LoadBox = -1;
        ContentBox.SetActive(false);
    }
    public void CloseThisUI()
    {
        CloseContent();
        Self.SetActive(false);
    }
    public void Refresh()
    {
        GameObject[] Box = GameObject.FindGameObjectsWithTag("ItemBox");
        for (int i = 0; i < Box.Length; i++)////
        {
            if (Inventory.GetComponent<Inventory>().BagList.ToArray().Length > i) {
                Debug.Log("Give ID:" + Inventory.GetComponent<Inventory>().BagList[i].ID);
                Box[i].GetComponent<ItemBox>().ID = Inventory.GetComponent<Inventory>().BagList[i].ID;
                Box[i].GetComponent<ItemBox>().Amount = Inventory.GetComponent<Inventory>().BagList[i].Amount;
                Box[i].GetComponent<ItemBox>().Refresh();
                Debug.Log("has stuff");
            }
            else
            {
                Box[i].GetComponent<ItemBox>().ID = 0;
                Box[i].GetComponent<ItemBox>().Amount = 0;
                Box[i].GetComponent<ItemBox>().Refresh();
                Debug.Log("Empty");
            }
        }
    }
    public void LoadContent(int ID,int Amount)
    {
        if (ContentBox.activeSelf== false)
        {
            ContentBox.SetActive(true);
        }
        LoadBox = ID;
        Nametext.text = JsonData.ItemsName(ID);
        Contenttext.text = JsonData.ItemsContent(ID);
        Amounttext.text = Amount.ToString();
        IMG.GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("IMG/" + JsonData.ItemsIMG(ID));
    }

    public void Mup()
    {
        MouseDown = false;
    }
    public void Mdown()
    {
        autouse = 0f;
        frist = true;
        MouseDown = true;
    }
    public void Eve2S()
    {
        ItemDec();
        frist = false;
    }
    public void Flashup()
    {
        Debug.Log("放太快了");
        if (frist)
        {
            ItemDec();
        }
    }
    public void ItemDec()
    {
        if(LoadBox != -1)
        {
            Inventory.GetComponent<Inventory>().DelItem(LoadBox, 1);
        }
        
    }
}
