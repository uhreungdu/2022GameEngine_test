using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _Instance;
    public static GameManager Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        if (_Instance == null)
            _Instance = FindObjectOfType<GameManager>();
        if (_Instance == null)
        {
            var go = new GameObject(nameof(GameManager));
            _Instance = go.GetComponent<GameManager>();
        }
            Instance = this;
    }

    public int coin;
    public ItemDatabase Itemdata;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
