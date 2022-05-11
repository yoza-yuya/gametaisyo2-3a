using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPoint : MonoBehaviour
{
    public bool mikakucount = false;
    public bool sikakucount = false;
    public bool tyoukakucount = false;
    public bool syokkakucount = false;
    public bool kyuukakucount = false;
    private int nowitemcount;
    public Text CountText;


    //味覚
    public bool Getmikakucount()
    {
        return mikakucount;
    }

    //視覚
    public bool Getsikakucount()
    {
        return sikakucount;
    }

    //触覚
    public bool Getsyokkakucount()
    {
        return syokkakucount;
    }

    //聴覚
    public bool Gettyoukakucount()
    {
        return tyoukakucount;
    }



    void Start()
    {
        nowitemcount = 0;
        CountText.text = "Count: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        //味覚(青色の玉)
        if (collider.gameObject.tag == "Item(mikaku)")
        {
            Debug.Log("味覚のアイテム取れたよ");
            nowitemcount = nowitemcount + 1;
            CountText.text = "Count: " + nowitemcount.ToString();
            mikakucount = true;
        }

        //触覚
        if (collider.gameObject.tag == "Item(syokkaku)")
        {
            Debug.Log("触覚のアイテム取れたよ");
            nowitemcount = nowitemcount + 1;
            CountText.text = "Count: " + nowitemcount.ToString();
            syokkakucount = true;
        }

        //聴覚
        if (collider.gameObject.tag == "Item(tyoukaku)")
        {
            Debug.Log("聴覚のアイテム取れたよ");
            nowitemcount = nowitemcount + 1;
            CountText.text = "Count: " + nowitemcount.ToString();
            tyoukakucount = true;
        }

        //視覚(緑色の玉)
        if (collider.gameObject.tag == "Item(sikaku)")
        {

            Debug.Log("視覚のアイテム取れたよ");
            nowitemcount = nowitemcount + 1;
            CountText.text = "Count: " + nowitemcount.ToString();
            sikakucount = true;
        }

        //嗅覚
        if (collider.gameObject.tag == "Item(kyuukaku)")
        {
            Debug.Log("嗅覚のアイテム取れたよ");
            nowitemcount = nowitemcount + 1;
            CountText.text = "Count: " + nowitemcount.ToString();
            kyuukakucount = true;
        }
    }
}
