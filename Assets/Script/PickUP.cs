using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUP : MonoBehaviour
{
    public GameObject Inventory;
    public int ItemID;
    // Start is called before the first frame update
    void Awake()
    {
        Inventory = GameObject.Find("PlayerInventory");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.layer == 8)
        {
            Inventory.GetComponent<Inventory>().AddItem(ItemID, 1);
        }
    }
}
