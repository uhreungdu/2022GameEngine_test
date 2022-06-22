using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(order = 0,fileName = "Itme DataBase",menuName = "study/Item/Create Item DB")]
public class ItemDatabase : ScriptableObject
{
    public ItemData[] ItemDatas;
}

[Serializable]
public class ItemData
{
    public string ItemName;
    public int item_Level;
    public Sprite item_image;
}

[Serializable]
public class swordData
{
    public string ItemName;
    public int item_Level;
    public float attackpower;
}
