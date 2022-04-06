using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SikakuCamera : MonoBehaviour
{
    bool SikakuSkillflg = false;    //コルーチンフラグ
    bool SikakuCameraflg = true;
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
        if (Input.GetKeyDown(KeyCode.P)&& !SikakuSkillflg && SikakuCameraflg)
        {
            StartCoroutine("SikakuSkill");
            SikakuCameraflg = false;
        }

    }
    IEnumerator SikakuSkill()
    {
        SikakuSkillflg = true;
        //サブカメラをアクティブに設定
        mainCamera.SetActive(false);
        subCamera.SetActive(true);
        Debug.Log("On");
        yield return new WaitForSeconds(10);
        //メインカメラをアクティブに設定
        mainCamera.SetActive(true);
        subCamera.SetActive(false);
        SikakuSkillflg = false;
        Debug.Log("Off");
    }
}
