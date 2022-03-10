using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VisualSkill : MonoBehaviour
{
    Renderer ren;
    private float time = 0f;
    private int i = 0;
    public int SkillTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<Renderer>();
        ren.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 5"))
        {
            ren.enabled = true;
            i = 1;
        }
        if (i >= 1)
        {
            time += Time.deltaTime;
        }
        if (time >= SkillTime)
        {
            ren.enabled = false;
            time = 0f;
            i = 0;
        }
    }
}
