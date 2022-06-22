using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectPoolingManager : MonoBehaviour
{
    public Managed_Prefab prefab_Database;
    
    // Start is called before the first frame update
    private Dictionary<string, GameObject> _prefabDatabase;
    public Dictionary<string, List<GameObject>> _ManagedObjects;
    

    private void Awake()
    {
        foreach (var prefabdatas in prefab_Database.prefabs)
        {
            _prefabDatabase.Add(prefabdatas.prepabname,prefabdatas.PrefabGameObject);
        }

        
    }

    public GameObject get(string gameobjectName)
    {
        if (!_prefabDatabase.ContainsKey(gameobjectName))
            return null;
        else
        {
            if(!_ManagedObjects.ContainsKey(gameobjectName))
                _ManagedObjects.Add(gameobjectName, new List<GameObject>());
            if(!_ManagedObjects[gameobjectName].Any(obj => obj.activeInHierarchy))
            {
                var possibleObj = _ManagedObjects[gameobjectName].FirstOrDefault(obj => obj.activeInHierarchy);
                return possibleObj;
            }
            else
            {
                var newObj = Instantiate(_prefabDatabase[gameobjectName]);
                _ManagedObjects[gameobjectName].Add(newObj);

                return newObj;
            }
        }
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
