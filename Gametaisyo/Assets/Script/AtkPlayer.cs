using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkPlayer : MonoBehaviour
{
    private Syokkaku Syokkaku;
    private Mikaku Mikaku;

    private Itemselect sw;

    void Start()
    {
        Syokkaku = GetComponent<Syokkaku>();
        Mikaku = GetComponent<Mikaku>();
        GameObject canvas = GameObject.Find("Canvas");
        sw = canvas.GetComponent<Itemselect>();
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal");
        float dy = Input.GetAxis("Vertical");

        /*
         * 武器選択UIで選択した武器で攻撃する
         */
        switch (sw.WeponType)
        {
            case 0:
                knife.Attack(dx, dy, sources[0]);
                break;
            case 1:
                hundGun.Attack(dx, dy, sources[1]);
                break;
            case 2:
                knife.Attack(dx, dy, sources[0]);
                break;
        }
    }
}
