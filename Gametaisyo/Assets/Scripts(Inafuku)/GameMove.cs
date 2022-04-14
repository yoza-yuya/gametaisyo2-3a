using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMove : MonoBehaviour
{
    public Health health;
    public bool deathswitch;

    public GameObject ImgGameOver;

    int endmenucount = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deathswitch = health.Getgameovercount();
        if(deathswitch == true)
        {
            StartCoroutine(ShowImageSecond(ImgGameOver, 2f));
        }

        ////////////////
        ///カーソルの色を変えるコード
        ///

        if (endmenucount == 1)
        {
            x = Input.GetAxisRaw("Vertical");

            //カーソルの位置の処理、連続入力の防止ここから

            //スティックが上
            if (x > 0)
            {
                af++;//上入力の間加算し続ける

                if (af == 1)//afが加算され続けている時、その値が1の瞬間のみ以下の処理を行う。故に連続入力の対策となる
                {
                    endmenucount--;


                }
            }
            else
            {
                af = 0;//スティックが離されるか別入力になったら0にする
            }
            //カーソルが１の時に更に上に上げられたらカーソルの位置を３に移動させる
            if (endmenucount <= 0)
            {
                endmenucount = 3;
            }

            //スティックが下
            if (x < 0)
            {
                df++;//下入力の間加算を続ける

                if (df == 1)
                {
                    endmenucount++;


                }
            }
            else
            {
                df = 0;
            }
            if (endmenucount >= 4)
            {
                endmenucount = 1;
            }
            //カーソルの位置の処理、連続入力の防止ここまで


            //カーソルカウントが1
            if (endmenucount == 1)
            {
                Text text1 = GameReStartText.GetComponent<Text>();
                text1.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }

            //カーソルカウントが1じゃない時の操作
            else if (endmenucount != 1)
            {
                Text text1 = GameReStartText.GetComponent<Text>();
                text1.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }

            //カーソルカウントが2
            if (endmenucount == 2)
            {
                Text text2 = TitleBackText.GetComponent<Text>();
                text2.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }

            //カーソルカウントが2じゃない時の操作
            else if (endmenucount != 2)
            {
                Text text2 = TitleBackText.GetComponent<Text>();
                text2.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }

            //カーソルカウントが3
            if (endmenucount == 3)
            {
                Text text3 = ExitText.GetComponent<Text>();
                text3.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }

            //カーソルカウントが3じゃない時の操作
            else if (endmenucount != 3)
            {
                Text text3 = ExitText.GetComponent<Text>();
                text3.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }


            ///テキストの色を変えるコード終わり
            ////////////////

            ////////////////
            ///カーソルの指して項目を選択した時に実行するコード


            bool kettei = Input.GetKeyDown("joystick button 0");


            if (kettei == true && endmenucount == 1)
            {
                Time.timeScale = 1;
                StartCoroutine("GoToGameScene");
            }
            if (kettei == true && endmenucount == 2)
            {
                Time.timeScale = 1;

                StartCoroutine("GoToTitleScene");

            }
            if (kettei == true && endmenucount == 3)
            {
                StartCoroutine("GameExit");
            }
        }
    }


    IEnumerator ShowImageSecond(GameObject targetObj, float sec)
    {
        targetObj.SetActive(true); //引数で指定されたオブジェクトを表示する
        yield return new WaitForSeconds(sec); // 引数で指定された秒数待つ
        targetObj.SetActive(false); //引数で指定されたオブジェクトを非表示にする
    }
}
