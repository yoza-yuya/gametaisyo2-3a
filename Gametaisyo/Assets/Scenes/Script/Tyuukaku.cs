using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyuukaku : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform target;

    // カーソル
    [SerializeField] Transform cursor;

    bool TyuukakuSkillflg = false;    //コルーチンフラグ
    bool TyuukakuCameraflg = true;
    private GameObject mainCamera;      //メインカメラ格納用
    private GameObject subCamera;       //サブカメラ格納用

    public ItemPoint itempoint;
    public bool YellowCount;
    bool isCalledOnce1 = false;

    void Start()
    {
        //メインカメラとサブカメラをそれぞれ取得
        mainCamera = GameObject.Find("MiniMapCamera");
        subCamera = GameObject.Find("TyuukakuMapCamera");

        //サブカメラを非アクティブにする
        subCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        YellowCount = itempoint.Getkyuukakucount();
        if (YellowCount == true)
        {
            if (!isCalledOnce1)
            {
                isCalledOnce1 = true;
                cursor.LookAt(target);
                StartCoroutine("GoalLood");
                //cursor.LookAt(target,10.0f);
            }
        }
    }

    IEnumerator TyuukakuSkill()
    {
        TyuukakuSkillflg = true;
        //サブカメラをアクティブに設定
        mainCamera.SetActive(false);
        subCamera.SetActive(true);
        Debug.Log("On");
        yield return new WaitForSeconds(90);
        //メインカメラをアクティブに設定
        mainCamera.SetActive(true);
        subCamera.SetActive(false);
        TyuukakuSkillflg = false;
        Debug.Log("Off");
    }

    IEnumerator GoalLood()
    {
        yield return new WaitForSeconds(10.0f);
        Destroy(cursor);
    }
}
