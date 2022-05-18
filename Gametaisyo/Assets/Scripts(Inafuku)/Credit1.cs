using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credit1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool kettei = Input.GetKeyDown("joystick button 0");


        if (kettei == true)
        {
            
            StartCoroutine("GoToCreditScene");
        }
    }

    IEnumerator GoToCreditScene()
    {
        
        yield return new WaitForSeconds(0.57f);
        SceneManager.LoadScene("CreditScene2");
    }
}
