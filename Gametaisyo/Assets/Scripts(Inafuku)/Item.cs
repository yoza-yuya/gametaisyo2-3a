using System;

public class Item
{
    // 種類を持っている
    public enum Type
    {
        BlueAube,
        GreenAube,
        writeAube,
        PurpleAube,
        YellowAube,

    }

    public Type type;

    // TODO:画像を持っている

    public Item(Item item)
    {
        this.type = item.type;
    }
}