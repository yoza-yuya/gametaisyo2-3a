using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    private Image img = null;
    private float timer = 0.0f;
    private int frameCount = 0;
    private bool fadeIn = false;

    void Start()
    {
        img = GetComponent<Image>();
        img.color = new Color(1, 1, 1, 1);
        img.fillAmount = 1;
        img.raycastTarget = true;
        fadeIn = true;
    }

    void Update()
    {
        if (frameCount > 2)
        {
            if (fadeIn)
            {
                //フェードイン中 
                if (timer < 1)
                {
                    img.color = new Color(1, 1, 1, 1 - timer);
                    img.fillAmount = 1 - timer;
                }
                //フェードイン完了 
                else
                {
                    img.color = new Color(1, 1, 1, 0);
                    img.fillAmount = 0;
                    img.raycastTarget = false;
                    timer = 0.0f;
                    fadeIn = false;
                }
                timer += Time.deltaTime;
            }
        }
        ++frameCount;
    }
}