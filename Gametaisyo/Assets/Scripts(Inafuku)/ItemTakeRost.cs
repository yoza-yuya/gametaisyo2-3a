﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTakeRost : MonoBehaviour
{
	// ぶつかった時の音
	public AudioClip se;
	// AudioClip再生用
	AudioSource audiosource1;

	//どこでも実行できるようにする
	public static ItemTakeRost instance;
	public static int GoalCount = 0;
	/// <summary>
	/// 衝突した時
	/// </summary>
	/// <param name="collision"></param>
	/// 

	
	
	void Start()
	{
		// AudioSourceコンポーネント取得
		audiosource1 = GetComponent<AudioSource>();

		
	}

	void OnTriggerEnter(Collider other)
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (other.gameObject.tag == "Player")
		{
			audiosource1.PlayOneShot(se);
			// 0.2秒後に消える
			Debug.Log("触れた");
			Destroy(gameObject, 0.2f);
			//GoalOpenスクリプトの呼び出し
			GameObject director = GameObject.Find("GameDirector");
			//director.GetComponent<GoalOpen>().Goalflg();
			GoalCount++;
		}
	}

    void Update()
    {

		GameObject goal1 = GameObject.Find("Goal (1)");
		GameObject goal2 = GameObject.Find("Goal (2)");
		GameObject goal3 = GameObject.Find("Goal (3)");
		GameObject goal4 = GameObject.Find("Goal (4)");


		if (GoalCount == 1)
        {
			Destroy(goal1);
			Debug.Log("消す１");

			
		}

		if (GoalCount == 2)
		{
			Destroy(goal2);
			Debug.Log("消す２");


		}

		if (GoalCount == 3)
		{
			Destroy(goal3);
			Debug.Log("消す３");


		}

		if (GoalCount == 4)
		{
			Destroy(goal4);
			Debug.Log("消す４");

		}
	}
}