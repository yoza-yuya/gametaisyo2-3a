using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update    
    public void Restart()
    {
        SceneManager.LoadScene("Game");

        Time.timeScale = 1f;//戻る
        Debug.Log("Restart");
    }

    public void Title()
    {
        SceneManager.LoadScene("Start");
        Time.timeScale = 1f;//戻る
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Help()
    {
        SceneManager.LoadScene("Help");

    }
}
