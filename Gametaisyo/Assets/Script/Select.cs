using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public void SampleScene()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
