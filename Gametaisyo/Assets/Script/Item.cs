using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // 種類を持っている
    public enum Type
    {
        RedTile,
        BlueTile,
        YellowTile,
        Key,
        Coin,
    }

    public Type type;

    public Item(Item item)
    {
        this.type = item.type;
    }
}
