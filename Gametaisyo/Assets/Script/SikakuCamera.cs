using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SikakuCamera : MonoBehaviour
{
    bool SikakuSkillflg = false;    //コルーチンフラグ
    bool SikakuCameraflg = true;
    private GameObject mainCamera;      //メインカメラ格納用
    private GameObject subCamera;       //サブカメラ格納用 


    //追加
    public ItemPoint itempoint;
    public bool WriteCount;
    bool isCalledOnce1 = false;

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

        WriteCount = itempoint.Gettyoukakucount();
        if (WriteCount == true)
        {
            if (!isCalledOnce1)
            {
                isCalledOnce1 = true;
                StartCoroutine("SikakuSkill");
                SikakuCameraflg = false;
            }
            
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
