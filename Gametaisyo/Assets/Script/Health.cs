﻿using System.Collections;
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
    public int BlueCount;
    //public int GetBlueCount()
    //{
    //    return BlueCount;
    //}


    //[SerializeField] private GameObject soul1;
    //[SerializeField] private GameObject soul2;
    //[SerializeField] private GameObject soul3;
    //[SerializeField] private GameObject soul4;
    //[SerializeField] private GameObject soul5;

    [SerializeField] private GameObject batten1;
    [SerializeField] private GameObject batten2;
    [SerializeField] private GameObject batten3;
    [SerializeField] private GameObject batten4;
    [SerializeField] private GameObject batten5;

    [SerializeField] private GameObject tate;




    public bool gameovercount = false;
    public bool Getgameovercount()
    {
        return gameovercount;
    }

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

        
        BlueCount = itempoint.Getmikakucount();
        //Debug.Log(BlueCount); 


        //GameObject PlayerObject = GameObject.Find("PlayerObject");
        //Blue = PlayerObject.GetComponent<ItemPoint>();


        //HPが０になったらゲームオーバーにいく
        if (nowHp <= 0)
        {
            //Debug.Log("GameOver");
            //SceneManager.LoadScene("GameOver");
            gameovercount = true;
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
                //BlueCount = 1;
            }
        }


        if (nowHp == 0)
        {
            batten1.SetActive(true);
            batten2.SetActive(true);
            batten3.SetActive(true);
            batten4.SetActive(true);
            batten5.SetActive(true);
        }

        if (nowHp == 1)
        {
            batten5.SetActive(false);

            batten1.SetActive(true);
            batten2.SetActive(true);
            batten3.SetActive(true);
            batten4.SetActive(true);
        }

        if (nowHp == 2)
        {
            batten4.SetActive(false);
            batten5.SetActive(false);

            batten1.SetActive(true);
            batten2.SetActive(true);
            batten3.SetActive(true);

        }

        if (nowHp == 3)
        {
            batten3.SetActive(false);
            batten4.SetActive(false);
            batten5.SetActive(false);

            batten1.SetActive(true);
            batten2.SetActive(true);

        }

        if (nowHp == 4)
        {
            batten2.SetActive(false);
            batten3.SetActive(false);
            batten4.SetActive(false);
            batten5.SetActive(false);

            batten1.SetActive(true);

        }

        if (nowHp == 5)
        {
            batten1.SetActive(false);
            batten2.SetActive(false);
            batten3.SetActive(false);
            batten4.SetActive(false);
            batten5.SetActive(false);

            

        }
    }


}