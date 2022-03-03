using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VisualSkill : MonoBehaviour
{
    Renderer ren;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            if (Input.GetKeyDown("joystick button 5"))
            {
                ren.enabled = false;
            }
            else
            {
                ren.enabled = true;
            }
        }
    }
}
