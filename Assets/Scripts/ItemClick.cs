using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemClick : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] string text;
    Item item;
    [SerializeField] Item.Type type;


    void Start()
    {
        item = ItemGenerator.instance.Spawn(type);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(this.text);
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false);
    }
}
