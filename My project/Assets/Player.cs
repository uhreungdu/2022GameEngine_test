using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            
            GameManager.Instance.coin += 1;
            var itemdat = GameManager.Instance.Itemdata.ItemDatas;

            var swordData = itemdat.Where(item => item.ItemName.Contains("Sword")).Select(item => new swordData
            {
                ItemName = item.ItemName,
                item_Level = item.item_Level,
                attackpower = 10 * item.item_Level
            });

            foreach (var item in swordData)
            {
                print($"{item.ItemName} : Lv.{item.item_Level} Atk: {item.attackpower}");
            }

        }
    }
}
