using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    //最大HPと現在のHP。
    int maxHp = 5;
    int nowHp;

    //public int mikaku;
    //GameObject PlayerObject;
    //ItemPoint Blue;

    public ItemPoint itempoint;

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
            if (nowHp > 0)
            {
                //現在のHPからダメージを引く
                nowHp = nowHp - damage;
                Debug.Log("After currentHp : " + nowHp);
            }
        }
    }

    private void Update()
    {

        int BlueCount;
        BlueCount = itempoint.Getmikakucount();
        //Debug.Log(BlueCount); 


        //GameObject PlayerObject = GameObject.Find("PlayerObject");
        //Blue = PlayerObject.GetComponent<ItemPoint>();


        //HPが０になったらゲームオーバーにいく
        if (nowHp <= 0)
        {
            Debug.Log("GameOver");
            //SceneManager.LoadScene("GameOverScene");
        }


        //mikaku++;
        //if (mikaku > 100)
        //{
        //    Blue.GetComponent<ItemPoint>().sita = false;
        //}

        if (BlueCount == 2)
        {
            //Debug.Log("回復できるよ");
            bool Healkettei = Input.GetKeyDown("joystick button 0");
            if (Healkettei == true && BlueCount == 2)
            {
                nowHp = nowHp + 1;
                Debug.Log("After currentHp : " + nowHp);
            }
        }


    }


}