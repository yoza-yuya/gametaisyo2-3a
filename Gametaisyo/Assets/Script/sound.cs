using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sound : MonoBehaviour
{
    // ぶつかった時の音
    public AudioClip se;
    public AudioClip se2;
    public AudioClip se3;
    // AudioClip再生用
    AudioSource audiosource1;

    int Php = 5;
    // Start is called before the first frame update
    void Start()
    {
        // AudioSourceコンポーネント取得
        audiosource1 = GetComponent<AudioSource>();


    }
    
    // playerにぶつかった時に音を鳴らす
    void OnCollisionEnter(Collision other)
    {
        if(Php < 5) {
            if (other.gameObject.name == "Enemy")
            {
                audiosource1.PlayOneShot(se);
            }
            Php += -1;
        }else if (Php < 1) {

            if (other.gameObject.name == "Enemy")
            {
                audiosource1.PlayOneShot(se2);
                SceneManager.LoadScene("GameOberScene");
            }
        }
        if(other.gameObject.name == "Item")
        {
            audiosource1.PlayOneShot(se3);
        }
    }
}
