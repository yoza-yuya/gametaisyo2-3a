using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    //最大HPと現在のHP。
    int maxHp = 4;
    int nowHp;


    public ItemPoint itempoint;
    public bool BlueCount;
    public bool PurpleCount;
    

    bool yon = false;
    bool notDamage = false;
    bool tateflag = false;


    float x;

    float af = 0, df = 0;
    bool tatchflag = false;

    [SerializeField] private GameObject soul4;


    [SerializeField] private GameObject batten1;
    [SerializeField] private GameObject batten2;
    [SerializeField] private GameObject batten3;
    [SerializeField] private GameObject batten4;

    [SerializeField] private GameObject tate;
    [SerializeField] private GameObject tate4;


    bool isCalledOnce1 = false;
    bool isCalledOnce2 = false;

    public bool gameovercount = false;
    public bool Getgameovercount()
    {
        return gameovercount;
    }

    void Start()
    {
        //現在のHPを3に。
        nowHp = 3;
        Debug.Log("Start currentHp : " + nowHp);
       
    }

    private void OnTriggerEnter(Collider collider)
    {
        //Enemyタグのオブジェクトに触れると
        if (collider.gameObject.tag == "Enemy")
        {
            tatchflag = true;
            if (tatchflag == true)
            {
                af++;//上入力の間加算し続ける

                if (af == 1)//afが加算され続けている時、その値が1の瞬間のみ以下の処理を行う。故に連続入力の対策となる
                {
                    //ダメージ
                    int damage = 1;
                    Debug.Log("damage : " + damage);
                    if (nowHp > 0 && notDamage == false)
                    {

                        //現在のHPからダメージを引く
                        nowHp = nowHp - damage;
                        Debug.Log("After currentHp : " + nowHp);
                    }
                    else if (nowHp > 0 && notDamage == true)
                    {
                        Debug.Log("攻撃を無かったことにするッッッ！！！");
                        notDamage = false;
                        tateflag = true;
                    }
                }
            }
        }
        if (collider.gameObject.tag != "Enemy")
        {
            tatchflag = false;
            af = 0;//スティックが離されるか別入力になったら0にする
        }
    }




    private void Update()
    {

        
        BlueCount = itempoint.Getmikakucount();
        PurpleCount = itempoint.Getsyokkakucount();
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

        
        if (BlueCount == true)
        {
            Debug.Log("回復しやがれバカが");
            if (!isCalledOnce1)
            {
                isCalledOnce1 = true;

                //StartCoroutine("HPheal");
                switch (nowHp)
                {
                    case 1:
                        nowHp = nowHp + 1;
                        Debug.Log("After currentHp : " + nowHp);
                        break;
                    case 2:
                        nowHp = nowHp + 1;
                        Debug.Log("After currentHp : " + nowHp);
                        break;
                    case 3:
                        nowHp = nowHp + 1;
                        Debug.Log("After currentHp : " + nowHp);
                        soul4.SetActive(true);
                        yon = true;
                        break;

                }

                //if (nowHp == 1)
                //{
                //    nowHp = nowHp + 1;
                //    Debug.Log("After currentHp : " + nowHp);
                //    //BlueCount = 1;
                //}else if (nowHp == 2)
                //{
                //    nowHp = nowHp + 1;
                //    Debug.Log("After currentHp : " + nowHp);
                //    //BlueCount = 1;
                //}
                //else if (nowHp == 3)
                //{
                //    nowHp = 4;
                //    Debug.Log("After currentHp : " + nowHp);
                //    yon = true;
                //}
            }

        }


        if (yon == true)
        {
            

            if (nowHp == 0)
            {
                batten1.SetActive(true);
                batten2.SetActive(true);
                batten3.SetActive(true);
                batten4.SetActive(true);

            }

            if (nowHp == 1)
            {
                batten2.SetActive(true);
                batten3.SetActive(true);
                batten4.SetActive(true);

                batten1.SetActive(false);


            }

            if (nowHp == 2)
            {
                batten3.SetActive(true);
                batten4.SetActive(true);

                batten1.SetActive(false);
                batten2.SetActive(false);


            }

            if (nowHp == 3)
            {

                batten4.SetActive(true);

                batten1.SetActive(false);
                batten2.SetActive(false);
                batten3.SetActive(false);
            }

            if (nowHp == 4)
            {

                batten1.SetActive(false);
                batten2.SetActive(false);
                batten3.SetActive(false);
                batten4.SetActive(false);
            }
           

        }
        

        if(yon == false)
        {
            if (nowHp == 0)
            {
                batten1.SetActive(true);
                batten2.SetActive(true);
                batten3.SetActive(true);
                //batten4.SetActive(true);

            }

            if (nowHp == 1)
            {
                batten2.SetActive(true);
                batten3.SetActive(true);
                //batten4.SetActive(true);

                batten1.SetActive(false);


            }

            if (nowHp == 2)
            {
                batten3.SetActive(true);
                //batten4.SetActive(true);

                batten1.SetActive(false);
                batten2.SetActive(false);


            }

            if (nowHp == 3)
            {

                //batten4.SetActive(true);

                batten1.SetActive(false);
                batten2.SetActive(false);
                batten3.SetActive(false);
            }
        }

        if (PurpleCount == true)
        {
            if (!isCalledOnce2)
            {
                Debug.Log("バリア！");
                isCalledOnce2 = true;
                tateflag = true;


            }
        }

        if (tateflag == true)
        {
            tate.SetActive(true);
            notDamage = true;
            if (BlueCount == true && nowHp == 4)
            {
                tate4.SetActive(true);
            }
        }
        else if (tateflag == false)
        {
            tate.SetActive(false);
            tate4.SetActive(false);
        }



    }

    
}