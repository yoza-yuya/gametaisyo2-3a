//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class GameMove : MonoBehaviour
//{
//    public Health health;
//    public bool deathswitch;

//    public GameObject ImgGameOver;

//<<<<<<< HEAD
//    int endmenucount = 1;
//=======

//    [SerializeField] private GameObject GOGameReStartText;
//    [SerializeField] private GameObject GOTitleBackText;
//    [SerializeField] private GameObject GOExitText;

//    [SerializeField] private GameObject GOCursor1;
//    [SerializeField] private GameObject GOCursor2;
//    [SerializeField] private GameObject GOCursor3;
//    int GOcursorcount = 1;

    
//>>>>>>> origin/inafuku1

//    float goz;

//    float ag = 0, dg = 0;
//    void Start()
//    {
//<<<<<<< HEAD

//=======
//        GOcursorcount = 1;
//        GOCursor2.SetActive(false);
//        GOCursor3.SetActive(false);
//>>>>>>> origin/inafuku1
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        deathswitch = health.Getgameovercount();
//<<<<<<< HEAD
//        if (deathswitch == true)
//        {
//            StartCoroutine(ShowImageSecond(ImgGameOver, 2f));
//        }

//        ////////////////
//        ///カーソルの色を変えるコード
//        ///

//        if (endmenucount == 1)
//        {
//            goz = Input.GetAxisRaw("Vertical");

//            //カーソルの位置の処理、連続入力の防止ここから

//            //スティックが上
//            if (goz > 0)
//            {
//                ag++;//上入力の間加算し続ける

//                if (ag == 1)//agが加算され続けている時、その値が1の瞬間のみ以下の処理を行う。故に連続入力の対策となる
//                {
//                    endmenucount--;


//                }
//            }
//            else
//            {
//                ag = 0;//スティックが離されるか別入力になったら0にする
//            }
//            //カーソルが１の時に更に上に上げられたらカーソルの位置を３に移動させる
//            if (endmenucount <= 0)
//            {
//                endmenucount = 3;
//            }

//            //スティックが下
//            if (goz < 0)
//            {
//                dg++;//下入力の間加算を続ける

//                if (dg == 1)
//                {
//                    endmenucount++;


//                }
//            }
//            else
//            {
//                dg = 0;
//            }
//            if (endmenucount >= 4)
//            {
//                endmenucount = 1;
//            }
//            //カーソルの位置の処理、連続入力の防止ここまで


//            //    //カーソルカウントが1
//            //    if (endmenucount == 1)
//            //    {
//            //        Tegozt tegozt1 = GameReStartTegozt.GetComponent<Tegozt>();
//            //        tegozt1.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
//            //    }

//            //    //カーソルカウントが1じゃない時の操作
//            //    else if (endmenucount != 1)
//            //    {
//            //        Tegozt tegozt1 = GameReStartTegozt.GetComponent<Tegozt>();
//            //        tegozt1.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
//            //    }

//            //    //カーソルカウントが2
//            //    if (endmenucount == 2)
//            //    {
//            //        Text tegozt2 = TitleBackTegozt.GetComponent<Tegozt>();
//            //        tegozt2.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
//            //    }

//            //    //カーソルカウントが2じゃない時の操作
//            //    else if (endmenucount != 2)
//            //    {
//            //        Text tegozt2 = TitleBackTegozt.GetComponent<Tegozt>();
//            //        tegozt2.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
//            //    }

//            //    //カーソルカウントが3
//            //    if (endmenucount == 3)
//            //    {
//            //        Text tegozt3 = ExitText.GetComponent<Tegozt>();
//            //        tegozt3.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
//            //    }

//            //    //カーソルカウントが3じゃない時の操作
//            //    else if (endmenucount != 3)
//            //    {
//            //        Text tegozt3 = ExitText.GetComponent<Text>();
//            //        tegozt3.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
//            //    }


//            //    ///テキストの色を変えるコード終わり
//            //    ////////////////

//            //    ////////////////
//            //    ///カーソルの指して項目を選択した時に実行するコード


//            //    bool kettei = Input.GetKeyDown("joystick button 0");


//            //    if (kettei == true && endmenucount == 1)
//            //    {
//            //        Time.timeScale = 1;
//            //        StartCoroutine("GoToGameScene");
//            //    }
//            //    if (kettei == true && endmenucount == 2)
//            //    {
//            //        Time.timeScale = 1;

//            //        StartCoroutine("GoToTitleScene");

//            //    }
//            //    if (kettei == true && endmenucount == 3)
//            //    {
//            //        StartCoroutine("GameEgozit");
//            //    }
//            //}
//        }


//        IEnumerator ShowImageSecond(GameObject targetObj, float sec)
//        {
//            targetObj.SetActive(true); //引数で指定されたオブジェクトを表示する
//            yield return new WaitForSeconds(sec); // 引数で指定された秒数待つ
//            targetObj.SetActive(false); //引数で指定されたオブジェクトを非表示にする
//        }
//=======
//        if(deathswitch == true)
//        {
//            StartCoroutine(ShowImageSecond(ImgGameOver, 2f));



//            if (GOcursorcount == 1)
//            {
//                goz = Input.GetAxisRaw("Vertical");

//                //カーソルの位置の処理、連続入力の防止ここから

//                //スティックが上
//                if (goz > 0)
//                {
//                    ag++;//上入力の間加算し続ける

//                    if (ag == 1)//agが加算され続けている時、その値が1の瞬間のみ以下の処理を行う。故に連続入力の対策となる
//                    {
//                        GOcursorcount--;


//                    }
//                }
//                else
//                {
//                    ag = 0;//スティックが離されるか別入力になったら0にする
//                }
//                //カーソルが１の時に更に上に上げられたらカーソルの位置を３に移動させる
//                if (GOcursorcount <= 0)
//                {
//                    GOcursorcount = 3;
//                }

//                //スティックが下
//                if (goz < 0)
//                {
//                    dg++;//下入力の間加算を続ける

//                    if (dg == 1)
//                    {
//                        GOcursorcount++;


//                    }
//                }
//                else
//                {
//                    dg = 0;
//                }
//                if (GOcursorcount >= 4)
//                {
//                    GOcursorcount = 1;
//                }
//                //カーソルの位置の処理、連続入力の防止ここまで


//                //カーソルが1
//                if (GOcursorcount == 1)
//                {
//                    GOCursor1.SetActive(true);
//                    GOCursor2.SetActive(false);
//                    GOCursor3.SetActive(false);

//                }

//                //カーソルが２にある時の操作
//                else if (GOcursorcount == 2)
//                {
//                    GOCursor1.SetActive(false);
//                    GOCursor2.SetActive(true);
//                    GOCursor3.SetActive(false);

//                    if (GOcursorcount == 1)
//                    {

//                    }

//                }

//                //カーソルが３にある時の操作
//                else if (GOcursorcount == 3)
//                {
//                    GOCursor1.SetActive(false);
//                    GOCursor2.SetActive(false);
//                    GOCursor3.SetActive(true);


//                }



//                bool GOkettei = Input.GetKeyDown("joystick button 0");


//                if (GOkettei == true && GOcursorcount == 1)
//                {
//                    Time.timeScale = 1;
//                    StartCoroutine("GoToGameScene");
//                }
//                if (GOkettei == true && GOcursorcount == 2)
//                {
//                    Time.timeScale = 1;

//                    StartCoroutine("GoToTitleScene");

//                }
//                if (GOkettei == true && GOcursorcount == 3)
//                {
//                    StartCoroutine("GameExit");
//                }
//            }
//        }

        

        
//    }


//    IEnumerator ShowImageSecond(GameObject targetObj, float sec)
//    {
//        targetObj.SetActive(true); //引数で指定されたオブジェクトを表示する
//        yield return new WaitForSeconds(sec); // 引数で指定された秒数待つ
//        targetObj.SetActive(false); //引数で指定されたオブジェクトを非表示にする
//    }

//    IEnumerator GoToGameScene()
//    {
//        yield return new WaitForSeconds(0.57f);
//        SceneManager.LoadScene("SampleScene");
//    }

//    IEnumerator GoToTitleScene()
//    {
//        yield return new WaitForSeconds(0.57f);
//        SceneManager.LoadScene("TitleScene");
//    }

//    IEnumerator GameExit()
//    {
//        yield return new WaitForSeconds(0.57f);

//        Application.Quit();
//>>>>>>> origin/inafuku1
//    }
//}
