using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPoint : MonoBehaviour
{
    public bool mikakucount = false;
    public bool sikakucount = false;
    public bool tyoukakucount = false;
    public bool syokkakucount = false;
    public bool kyuukakucount = false;

    

    public bool Getmikakucount()
    {
        return mikakucount;
    }

    //public Health Health;

       void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        //味覚
        if (collider.gameObject.tag == "Item(mikaku)")
        {
            Debug.Log("味覚のアイテム取れたよ");
            mikakucount = true;
        }

        //触覚
        if (collider.gameObject.tag == "Item(syokkaku)")
        {
            Debug.Log("触覚のアイテム取れたよ");
            syokkakucount = true;
        }

        //聴覚
        if (collider.gameObject.tag == "Item(tyoukaku)")
        {
            Debug.Log("聴覚のアイテム取れたよ");
            tyoukakucount = true;
        }

        //視覚
        if (collider.gameObject.tag == "Item(sikaku)")
        {
            Debug.Log("視覚のアイテム取れたよ");
            sikakucount = true;
        }

        //嗅覚
        if (collider.gameObject.tag == "Item(kyuukaku)")
        {
            Debug.Log("嗅覚のアイテム取れたよ");
            kyuukakucount = true;
        }
    }
}
