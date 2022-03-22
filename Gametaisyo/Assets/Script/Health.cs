//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;

//public class Health : MonoBehaviour
//{
//    //最大HPと現在のHP。
//    int maxHp = 5;
//    int nowHp;

//    public int mikaku;
//    GameObject PlayerObject;
//    ItemPoint Blue;

//    void Start()
//    {
//        //現在のHPを最大HPと同じに。
//        nowHp = maxHp;
//        Debug.Log("Start currentHp : " + nowHp);
//        PlayerObject = GameObject.Find;
//        Blue = PlayerObject.GetComponent<ItemPoint>();
//    }

//    private void OnTriggerEnter(Collider collider)
//    {
//        //Enemyタグのオブジェクトに触れると
//        if (collider.gameObject.tag == "Enemy")
//        {
//            //ダメージ
//            int damage = 1;
//            Debug.Log("damage : " + damage);
//            if (nowHp > 0)
//            {
//                //現在のHPからダメージを引く
//                nowHp = nowHp - damage;
//                Debug.Log("After currentHp : " + nowHp);
//            }
//        }
//    }

//    private void Update()
//    {
//        //HPが０になったらゲームオーバーにいく
//        if (nowHp <= 0)
//        {
//            Debug.Log("GameOver");
//            //SceneManager.LoadScene("GameOverScene");
//        }

        

//        //if ()
//        //{

//        //}

//    }


//}