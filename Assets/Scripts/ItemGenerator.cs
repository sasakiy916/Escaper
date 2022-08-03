using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] ItemDataBase items;
    public static ItemGenerator instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public Item Spawn(Item.Type type)
    {
        foreach (Item item in items.items)
        {
            if (item.type == type)
            {
                return new Item(item.type, item.sprite);
            }
        }
        return null;
    }
}
