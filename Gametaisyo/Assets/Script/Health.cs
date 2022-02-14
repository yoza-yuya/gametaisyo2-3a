using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    //最大HPと現在のHP。
    int maxHp = 100;
    int currentHp;
    //Sliderを入れる
    public Slider slider;

    void Start()
    {
        //Sliderを満タンにする。
        slider.value = 1;
        //現在のHPを最大HPと同じに。
        currentHp = maxHp;
        Debug.Log("Start currentHp : " + currentHp);
    }

    private void OnTriggerEnter(Collider collider)
    {
        //Enemyタグのオブジェクトに触れると
       if (collider.gameObject.tag == "Enemy")
        {
            //ダメージ
            int damage = 20;
            Debug.Log("damage : " + damage);

            //現在のHPからダメージを引く
            currentHp = currentHp - damage;
            Debug.Log("After currentHp : " + currentHp);

            slider.value = (float)currentHp / (float)maxHp; ;
            Debug.Log("slider.value : " + slider.value);
        }
    }
}
