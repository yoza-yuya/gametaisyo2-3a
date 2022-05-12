using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VisualSkill : MonoBehaviour
{
    Vector3 area;
    private float time = 0f;
    public int AreaTime = 4;
    public float Area = 1.8f;
    private int i = 0;


    /// <追加の領域>
    public ItemPoint itempoint;
    public bool GreenCount;

    bool isCalledOnce = false;
    /// 

    // Start is called before the first frame update
    void Start()
    {
        area = gameObject.transform.localScale;
        area.x = 0;
        area.y = 0;
        area.z = 0;
        gameObject.transform.localScale = area;
    }

    // Update is called once per frame
    void Update()
    {
        GreenCount = itempoint.Getsikakucount();


        if (GreenCount == true)
        {
            if (!isCalledOnce)
            {
                Debug.Log("主神の眼力を！");
                isCalledOnce = true;
                i = 1;

                //time += Time.deltaTime;
                //if (area.x <= 200)
                //{
                //    area.x = area.x + Area;
                //    area.y = area.y + Area;
                //    area.z = area.z + Area;
                //    gameObject.transform.localScale = area;
                //}
            }
        }
        if (i >= 1)
        {
            Debug.Log("ああああ");
            time += Time.deltaTime;
            if (area.x <= 200)
            {
                Debug.Log("いいいい");
                area.x = area.x + Area;
                area.y = area.y + Area;
                area.z = area.z + Area;
                gameObject.transform.localScale = area;
            }
        }
        if (time >= AreaTime)
        {
            Debug.Log("うううう");
            time = 0f;
            area.x = 0;
            area.y = 0;
            area.z = 0;
            gameObject.transform.localScale = area;
            i = 0;
        }
    }
}
