using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTakeRost : MonoBehaviour
{
    int DestroyFlg;
	private GameObject goal;
    /// <summary>
    /// 衝突した時
    /// </summary>
    /// <param name="collision"></param>
    /// 
    void Start()
    {
        goal = GameObject.Find("Goal");
    }
	void OnTriggerEnter(Collider other)
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (other.gameObject.tag == "Player")
		{
            // 0.2秒後に消える
            Destroy(gameObject, 0.2f);
            DestroyFlg++;
            //Debug.Log(DestroyFlg);
        }
        Debug.Log(DestroyFlg);
    }
void Update()
    {
        if (DestroyFlg > 4)
        {
            goal.SetActive(false);
            Debug.Log("Goal");
        }
    }
}