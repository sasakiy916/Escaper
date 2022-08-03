using UnityEngine;
using System;

[Serializable]
public class Item
{
    public enum Type
    {
        Cube,
        Ball,
        Cylinder,
    }

    public Type type;
    public Sprite sprite;
    public Item(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}
