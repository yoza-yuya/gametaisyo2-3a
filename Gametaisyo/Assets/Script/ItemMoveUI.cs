using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemMoveUI : MonoBehaviour
{
    public RectTransform a;//RectTransform型の変数
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        a.position += new Vector3(0.1f, 0, 0);
    }

}
