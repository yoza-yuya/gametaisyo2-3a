using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTakeRost : MonoBehaviour
{
	public int DestroyFlg = 0;
	private GameObject Goal;
    /// <summary>
    /// 衝突した時
    /// </summary>
    /// <param name="collision"></param>
    /// 
    void Start()
    {
        Goal = GameObject.Find("Goal");
    }
	void OnTriggerEnter(Collider other)
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (other.gameObject.tag == "Player")
		{
			// 0.2秒後に消える
			Destroy(gameObject, 0.2f);
			DestroyFlg++;
            Debug.Log("Deth");
		}
    }
void Update()
    {
        if (DestroyFlg > 4)
        {
            Goal.SetActive(false);
            Debug.Log("Goal");
        } 
    }
}