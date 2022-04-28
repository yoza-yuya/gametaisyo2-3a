using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // 列挙型：種類
    public enum Type
    {
        tyoukaku,
        kyuukaku,
        mikaku,
        syokkaku,
        sikaku,
    }

    public Type type;

    public Item(Item item)
    {
        this.type = item.type;
    }
}
