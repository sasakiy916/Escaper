using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    Item item;
    Image image;
    //Slotが空かチェック
    public bool IsEmpty
    {
        get => item == null;
    }
    // public bool IsEmpty()
    // {
    //     // if (item == null)
    //     // {
    //     //     return true;
    //     // }
    //     // return false;
    //     return item == null;
    // }
    void Awake()
    {
        image = GetComponent<Image>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        UseItem();
        // Debug.Log("test");
    }
    public void SetItem(Item item)
    {
        this.item = item;
        image.sprite = item.sprite;
    }

    public void UseItem()
    {
        if (!IsEmpty)
        {
            Debug.Log("使用しました");
            item = null;
            image.sprite = null;
        }
    }
}
