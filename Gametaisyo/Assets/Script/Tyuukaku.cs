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
		cursor.LookAt(target);
	}

	IEnumerator SikakuSkill()
	{
		TyuukakuSkillflg = true;
		//サブカメラをアクティブに設定
		mainCamera.SetActive(false);
		subCamera.SetActive(true);
		Debug.Log("やじるし！");
		yield return new WaitForSeconds(10);
		//メインカメラをアクティブに設定
		mainCamera.SetActive(true);
		subCamera.SetActive(false);
		TyuukakuSkillflg = false;
		Debug.Log("消えちゃったやじるし");
	}
}
