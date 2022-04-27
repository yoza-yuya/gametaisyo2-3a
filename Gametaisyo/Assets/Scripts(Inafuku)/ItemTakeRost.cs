using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTakeRost : MonoBehaviour
{
	//どこでも実行できるようにする
	public static ItemTakeRost instance;
	public static int GoalCount;
	/// <summary>
	/// 衝突した時
	/// </summary>
	/// <param name="collision"></param>
	void OnTriggerEnter(Collider other)
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (other.gameObject.tag == "Player")
		{
			// 0.2秒後に消える
			Debug.Log("触れた");
			Destroy(gameObject, 0.2f);
			//GoalOpenスクリプトの呼び出し
			GameObject director = GameObject.Find("GameDirector");
			//director.GetComponent<GoalOpen>().Goalflg();
			GoalCount++;
		}
	}
}