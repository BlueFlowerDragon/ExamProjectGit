using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBox : MonoBehaviour
{
    public int BoxID;
    public int ID;
    public int Amount;
    public Text Amounttext;
    public string IMGname;
    public GameObject IMG;
    public Inventory Inventory;
    // Start is called before the first frame update
    void Start()
    {
        Inventory = GameObject.Find("PlayerInventory").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Refresh()
    {
        if (Amount > 0)
        {
            Amounttext.text = Amount.ToString();
        }
        else
        {
            Amounttext.text = "";
        }
        switch (ID)
        {
            case 1:
                IMGname = "choco";
                break;
            case 2:
                IMGname = "choco_D";
                break;
            case 3:
                IMGname = "cure";
                break;
            case 4:
                IMGname = "cure_R";
                break;
            case 5:
                IMGname = "cure_O";
                break;
            case 6:
                IMGname = "cure_Y";
                break;
            case 7:
                IMGname = "cure_G";
                break;
            case 8:
                IMGname = "cure_B";
                break;
            case 9:
                IMGname = "key";
                break;
            default:
                IMGname = "";
                break;
        }
        IMG.GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("IMG/"+IMGname.ToString());
    }
    public void Open()
    {
        if(ID != 0)
        {
            Inventory.LoadContent(BoxID);
        }
    }
}
