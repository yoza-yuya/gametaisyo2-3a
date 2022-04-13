using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPoint : MonoBehaviour
{
    public int mikakucount = 0;
    public int sikakucount = 0;
    public int tyoukakucount = 0;
    public int syokkakucount = 0;
    public int kyuukakucount = 0;

    public bool sita = true;

    public int Getmikakucount()
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
            mikakucount = 2;
        }
        //触覚
        if (collider.gameObject.tag == "Item(syokkaku)")
        {
            Debug.Log("味覚のアイテム取れたよ");
            syokkakucount = 2;
        }
    }
}
