using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;

    public GameObject goal;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == Player.name)
        {
            goal.GetComponent<Text>();
            goal.SetActive(true);
            Player.SetActive(false);

            if (other.gameObject.tag == "Player")
            {
                SceneManager.LoadScene("ClearScene");
                Debug.Log("b");
            }
        }
    }
}
   