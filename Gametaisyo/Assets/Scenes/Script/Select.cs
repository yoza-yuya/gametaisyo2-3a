using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select : MonoBehaviour
{

    [SerializeField] private GameObject PauseMenuCanvas;
    public GameObject curObj;
    Cursor cur;

    //int Pauseswich;
    bool Pausecount = false;
    //public TimeCounter TimeCounter;

    [SerializeField] private GameObject GameReStartText;
    [SerializeField] private GameObject TitleBackText;
    [SerializeField] private GameObject ExitText;


    int Cursorcount = 1;
    float x;

    float af = 0, df = 0;





    //public bool DontDestroyEnabled = true;

    //カウントアップ
    private float countup = 0.0f;

    void Start()
    {

        //Pauseswich = TimeCounter.Pozuswich;
        PauseMenuCanvas.SetActive(false);
        //cur = curObj.GetComponent<Cursor>();

        Cursorcount = 1;
        Text text1 = GameReStartText.GetComponent<Text>();
        text1.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);


        //if (DontDestroyEnabled)
        //{
        //    // Sceneを遷移してもオブジェクトが消えないようにする
        //    DontDestroyOnLoad(this);
        //}
    }

    void Update()
    {
        bool start = Input.GetKeyDown("joystick button 7");

        if (start == true && Pausecount == false)
        {
            Time.timeScale = 0;
            PauseMenuCanvas.SetActive(true);
            Pausecount = true;

        }
        else if (start == true && Pausecount == true)
        {
            Time.timeScale = 1;
            PauseMenuCanvas.SetActive(false);
            Pausecount = false;

        }

        ////////////////
        ///カーソルの色を変えるコード
        ///

        if (Pausecount == true)
        {
            x = Input.GetAxisRaw("Vertical");

            //カーソルの位置の処理、連続入力の防止ここから

            //スティックが上
            if (x > 0)
            {
                af++;//上入力の間加算し続ける

                if (af == 1)//afが加算され続けている時、その値が1の瞬間のみ以下の処理を行う。故に連続入力の対策となる
                {
                    Cursorcount--;


                }
            }
            else
            {
                af = 0;//スティックが離されるか別入力になったら0にする
            }
            //カーソルが１の時に更に上に上げられたらカーソルの位置を３に移動させる
            if (Cursorcount <= 0)
            {
                Cursorcount = 3;
            }

            //スティックが下
            if (x < 0)
            {
                df++;//下入力の間加算を続ける

                if (df == 1)
                {
                    Cursorcount++;


                }
            }
            else
            {
                df = 0;
            }
            if (Cursorcount >= 4)
            {
                Cursorcount = 1;
            }
            //カーソルの位置の処理、連続入力の防止ここまで


            //カーソルカウントが1
            if (Cursorcount == 1)
            {
                Text text1 = GameReStartText.GetComponent<Text>();
                text1.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }

            //カーソルカウントが1じゃない時の操作
            else if (Cursorcount != 1)
            {
                Text text1 = GameReStartText.GetComponent<Text>();
                text1.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }

            //カーソルカウントが2
            if (Cursorcount == 2)
            {
                Text text2 = TitleBackText.GetComponent<Text>();
                text2.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }

            //カーソルカウントが2じゃない時の操作
            else if (Cursorcount != 2)
            {
                Text text2 = TitleBackText.GetComponent<Text>();
                text2.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }

            //カーソルカウントが3
            if (Cursorcount == 3)
            {
                Text text3 = ExitText.GetComponent<Text>();
                text3.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }

            //カーソルカウントが3じゃない時の操作
            else if (Cursorcount != 3)
            {
                Text text3 = ExitText.GetComponent<Text>();
                text3.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }


            ///テキストの色を変えるコード終わり
            ////////////////

            ////////////////
            ///カーソルの指して項目を選択した時に実行するコード


            bool kettei = Input.GetKeyDown("joystick button 0");


            if (kettei == true && Cursorcount == 1)
            {
                Time.timeScale = 1;
                StartCoroutine("GoToGameScene");
            }
            if (kettei == true && Cursorcount == 2)
            {
                Time.timeScale = 1;

                StartCoroutine("GoToTitleScene");

            }
            if (kettei == true && Cursorcount == 3)
            {
                StartCoroutine("GameExit");
            }
        }



        if (Pausecount == false && Cursorcount != 1)
        {
            Cursorcount = 1;

            //Text text1 = GameReStartText.GetComponent<Text>();
            //text1.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);

            //Text text2 = TitleBackText.GetComponent<Text>();
            //text2.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);

            //Text text3 = ExitText.GetComponent<Text>();
            //text3.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }


        ///カーソルの指して項目を選択した時に実行するコード終わり
        ////////////////


    }
    IEnumerator GoToGameScene()
    {
        Time.timeScale = 1;
        yield return new WaitForSeconds(0.57f);
        SceneManager.LoadScene("SampleScene");
    }

    IEnumerator GoToTitleScene()
    {
        Time.timeScale = 1;
        yield return new WaitForSeconds(0.57f);
        SceneManager.LoadScene("TitleScene");
    }

    IEnumerator GameExit()
    {
        yield return new WaitForSeconds(0.57f);

        Application.Quit();
    }
}
