using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(order = 0,fileName = "Prefab DataBase",menuName = "study/PrefabDataBase/Create Prefab DB")]
public class Managed_Prefab : ScriptableObject
{
    public managedprefab[] prefabs;
}

[Serializable]
public class managedprefab
{
    public string prepabname;
    public GameObject PrefabGameObject;
}
