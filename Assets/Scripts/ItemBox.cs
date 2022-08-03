using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    //staticでどこからでも参照出来るようになる
    public static ItemBox instance;
    [SerializeField] Slot[] slots;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        slots = GetComponentsInChildren<Slot>();
    }
    public void SetItem(Item item)
    {
        foreach (Slot slot in slots)
        {
            if (slot.IsEmpty)
            {
                slot.SetItem(item);
                return;
            }
        }
    }
}
