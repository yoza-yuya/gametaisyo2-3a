using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select : MonoBehaviour
{
    public Button button;
    public Button button2;
    public Button button3;

    void OnEnable()
    {

        button.GetComponent<Button>().Select();

        //ボタンが選択された状態になる
        button.GetComponent<Button>().Select();
        Debug.Log("aaa");

    }
}
