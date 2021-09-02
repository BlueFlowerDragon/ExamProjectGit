using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ItemList
{
    public ItemData[] ItemEntityList;
}

[Serializable]
public class ItemData
{
    public int ID;
    public string Name;
    public string Description;
    public string IMG;
    public int BuyPrice;
    public int SellPrice;
}

[Serializable]
public class Recipes
{
    public Detaillist[] Recipe;
}

[Serializable]
public class Detaillist
{
    public int ID;
    public int Product;
    public List<int> MainMaterial;
    public List<int> Demand;
}