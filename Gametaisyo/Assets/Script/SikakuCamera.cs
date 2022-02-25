using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SikakuCamera : MonoBehaviour
{

    private GameObject mainCamera;      //メインカメラ格納用
    private GameObject subCamera;       //サブカメラ格納用 
    private float EffectiveTime = 10f;   //効果時間
    private float time;

    void Start()
    {
        //メインカメラとサブカメラをそれぞれ取得
        mainCamera = GameObject.Find("MiniMapCamera");
        subCamera = GameObject.Find("SikakuMapCamera");

        //サブカメラを非アクティブにする
        subCamera.SetActive(false);
    }


    void Update()
    {
        //スペースキーが押されてから
        if (Input.GetKey(KeyCode.A))
        {
            //押してからの時間が効果時間を超えるまで
            while (time>EffectiveTime)
             {
            //サブカメラをアクティブに設定
            mainCamera.SetActive(false);
            subCamera.SetActive(true);
                time += Time.deltaTime;
                Debug.Log("On");
            }
        }
        //メインカメラをアクティブに設定
        subCamera.SetActive(false);
        mainCamera.SetActive(true);
        Debug.Log("Off");
    }
}
