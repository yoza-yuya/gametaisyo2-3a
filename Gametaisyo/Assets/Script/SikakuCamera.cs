using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SikakuCamera : MonoBehaviour
{

    private GameObject mainCamera;      //メインカメラ格納用
    private GameObject subCamera;       //サブカメラ格納用 
 
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
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine("SikakuSkill");
        }

    }
    IEnumerator SikakuSkill()
    {
        //サブカメラをアクティブに設定
        mainCamera.SetActive(false);
        subCamera.SetActive(true);
        Debug.Log("On");
        yield return new WaitForSeconds(10);
        //メインカメラをアクティブに設定
        mainCamera.SetActive(true);
        subCamera.SetActive(false);
        Debug.Log("Off");
    }
}
