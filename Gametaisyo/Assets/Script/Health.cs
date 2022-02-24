using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    //最大HPと現在のHP。
    int maxHp = 5;
    int nowHp;
    void Start()
    {
        //現在のHPを最大HPと同じに。
        nowHp = maxHp;
        Debug.Log("Start currentHp : " + nowHp);
    }

    private void OnTriggerEnter(Collider collider)
    {
        //Enemyタグのオブジェクトに触れると
       if (collider.gameObject.tag == "Enemy")
        {
            //ダメージ
            int damage = 1;
            Debug.Log("damage : " + damage);

            //現在のHPからダメージを引く
            nowHp = nowHp - damage;
            Debug.Log("After currentHp : " + nowHp);
        }
    }
}
