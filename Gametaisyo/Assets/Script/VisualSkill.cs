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
        if (Input.GetKeyDown("joystick button 5"))
        {
            i = 1;
            Debug.Log("1");
        }
        if (i >= 1)
        {
            time += Time.deltaTime;
            if (area.x <= 200)
            {
                area.x = area.x + Area;
                area.y = area.y + Area;
                area.z = area.z + Area;
                gameObject.transform.localScale = area;
            }
            Debug.Log("2");
        }
        if (time >= AreaTime)
        {
            time = 0f;
            area.x = 0;
            area.y = 0;
            area.z = 0;
            gameObject.transform.localScale = area;
            i = 0;
            Debug.Log("3");
        }
    }
}
