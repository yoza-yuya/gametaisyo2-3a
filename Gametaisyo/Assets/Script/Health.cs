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

    //public int mikaku;
    //GameObject PlayerObject;
    //ItemPoint Blue;

    public ItemPoint itempoint;
    public bool BlueCount;
    //public int GetBlueCount()
    //{
    //    return BlueCount;
    //}

    bool yon = false;

    [SerializeField] private GameObject soul4;


    [SerializeField] private GameObject batten1;
    [SerializeField] private GameObject batten2;
    [SerializeField] private GameObject batten3;
    [SerializeField] private GameObject batten4;
    

    [SerializeField] private GameObject tate;


    bool isCalledOnce = false;

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

        
        if (BlueCount == true)
        {
            Debug.Log("回復しやがれバカが");
            if (!isCalledOnce)
            {
                isCalledOnce = true;

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

        
    }

    //IEnumerator HPheal()
    //{
    //    yield return new WaitForSeconds(0.57f);
        
    //}
}