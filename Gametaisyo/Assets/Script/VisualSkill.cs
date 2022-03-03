using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VisualSkill : MonoBehaviour
{
    Renderer ren;
    Light light;
    private float time = 0f;
    private int i = 0;
    public int SkillTime = 5; 
    // Start is called before the first frame update
    void Start()
    {
        if (this.gameObject.tag == "Light")
        {
            light = GetComponent<Light>();
            light.enabled = false;
        }
        else
        {
            ren = GetComponent<Renderer>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 5"))
        {
            if (this.gameObject.tag == "Light")
            {
                light.enabled = true;
            }
            else
            {
                ren.enabled = false;
            }
            i = 1;
        }
        if (this.gameObject.tag == "Light")
        {
            if (i == 1)
            {
                time += Time.deltaTime;
            }
            if (time >= SkillTime)
            {
                light.enabled = false;
                time = 0f;
                i = 0;
            }
        }
        else
        {
            if (i == 1) {
                time += Time.deltaTime;
            }
            if (time >= SkillTime) {
                ren.enabled = true;
                time = 0f;
                i = 0;
            }
        }
    }
}
