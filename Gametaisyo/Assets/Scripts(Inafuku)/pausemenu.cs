//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class pausemenu : MonoBehaviour
//{
//    [SerializeField] private GameObject PauseMenuCanvas;
//    public GameObject curObj;
//    Cursor cur;

//    //int Pauseswich;
//    int Pausecount = 0;
//    //public TimeCounter TimeCounter;

//    void Start()
//    {
//        //Pauseswich = TimeCounter.Pozuswich;
//        PauseMenuCanvas.SetActive(false);
//        //cur = curObj.GetComponent<Cursor>();
//    }

//    void Update()
//    {
//        bool start = Input.GetKeyDown("joystick button 7");

//        if (start == true && Pausecount == 0)
//        {
//            Time.timeScale = 0;
//            PauseMenuCanvas.SetActive(true);
//            Pausecount = 1;

//        }
//        else if (start == true && Pausecount == 1)
//        {
//            Time.timeScale = 1;
//            PauseMenuCanvas.SetActive(false);
//            Pausecount = 0;

//        }

//        //if (pausePanel.activeSelf == false)
//        //{
//        //    cur.enabled = false;
//        //}
//        //else
//        //{
//        //    cur.enabled = true;
//        //}
//    }
//}
