using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AitemGet : MonoBehaviour
{
    public Image Dimg;

    // Start is called before the first frame update
    public void Start()
    {
        Dimg.color = Color.clear;
        Debug.Log(" ");
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("aho ");
        if (collider.gameObject.tag == "Item(syokkaku)")
        {
            //*画面を赤塗りにする
            this.Dimg.color = new Color(0.5f, 0f, 0f, 0.5f);
            //Debug.Log("damage  ");

        }
        if (collider.gameObject.tag == "Item(mikaku)")
        {
            //*画面をグレーにする
            this.Dimg.color = new Color(0.5f, 0.5f, 0.5f, 1f);
            //Debug.Log("damage  ");

        }
        if (collider.gameObject.tag == "Item(tyoukaku)")
        {
            //*画面を青塗りにする
            this.Dimg.color = new Color(0f, 0f, 1f, 1f);
            //Debug.Log("damage  ");

        }
        if (collider.gameObject.tag == "Item(sikaku)")
        {
            //*画面を灰塗りにする
            this.Dimg.color = new Color(0.5f, 0.5f, 0.5f, 1f);
            //Debug.Log("damage  ");

        }
        if (collider.gameObject.tag == "Item(kyuukaku)")
        {
            //*画面を赤塗りにする
            this.Dimg.color = new Color(0.5f, 0f, 0.5f, 0.5f);
            //Debug.Log("damage  ");

        }
    }

    void Update()
    {
        //時間が経過するにつれて徐々に透明にします。
        this.Dimg.color = Color.Lerp(this.Dimg.color, Color.clear, Time.deltaTime);

    }
}
