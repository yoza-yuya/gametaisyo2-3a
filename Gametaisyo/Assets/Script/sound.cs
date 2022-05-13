using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sound : MonoBehaviour
{
    // ぶつかった時の音
    public AudioClip se;
    // AudioClip再生用
    AudioSource audiosource1;

    // Start is called before the first frame update
    void Start()
    {
        // AudioSourceコンポーネント取得
        audiosource1 = GetComponent<AudioSource>();


    }
    
    // playerにぶつかった時に音を鳴らす
    void OnCollisionEnter(Collision hit)
    {
            if (hit.gameObject.name == "Player")
            {
                audiosource1.PlayOneShot(se);
                Debug.Log("痛い");
            }
        
    }
}
