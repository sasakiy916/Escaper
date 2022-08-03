using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "item")]
public class ItemDataBase : ScriptableObject
{
    public List<Item> items = new List<Item>();
}
