using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymove : MonoBehaviour
{
    Vector3 rot;
    Vector3 pos;
    EnemyTurn ene;
    public GameObject Cap;
    public GameObject Enemy;
    public float i = 1f;
    public float j = 0f;
    int time = 0;
    bool flg = false;
    int flg2 = 0;
    public int flg3 = 0;
    float SpeedX = 3f;
    float SpeedZ = 0f;
    private void Start()
    {
        pos = Enemy.transform.position;
        rot = Enemy.transform.eulerAngles;
    }
    void Update()
    {
        ene = Cap.GetComponent<EnemyTurn>();
        flg2 = ene.flg;
        if (flg3 == 0) {
            if (flg2 == 1)
            {
                i = ene.a;
                flg3 = 1;
                Debug.Log(ene.a);
            }
        }
        if(ene.flg == 0)
        {
            flg3 = 0;
        }
        pos.x += SpeedX * Time.deltaTime;
        pos.z += SpeedZ * Time.deltaTime;
        Enemy.transform.position = pos;
        time += 1;

        if (i >= 1f && i < 2f)
        {
            rot.y = 0;
            Enemy.transform.eulerAngles = rot;
            SpeedX = 5f;
            SpeedZ = 0f;
        }
        else if (i >= 2f && i < 3f)
        {
            rot.y = 180;
            Enemy.transform.eulerAngles = rot;
            SpeedX = -5f;
            SpeedZ = 0f;
        }
        else if (i >= 3f && i < 4f)
        {
            rot.y = 270;
            Enemy.transform.eulerAngles = rot;
            SpeedX = 0f;
            SpeedZ = 5f;
        }
        else if (i >= 4f && i <= 5f)
        {
            rot.y = 90;
            Enemy.transform.eulerAngles = rot;
            SpeedX = 0f;
            SpeedZ = -5f;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            if (time >= 5 || flg == false)
            {
                j = Random.Range(1f, 5f);
                if (i >= 1f && i < 2f)
                {
                    if (j >= 1f && j < 1.5f)
                    {
                        i = 2f;
                    }
                    else if (j >= 1.5f && j < 3f)
                    {
                        i = 1f;
                    }
                    else if (j >= 3f && j < 5f)
                    {
                        i = Random.Range(3f, 5f);
                        flg = true;
                    }
                }
                else if (i >= 2f && i < 3f)
                {
                    if (j >= 1f && j < 1.5f)
                    {
                        i = 1f;
                    }
                    else if (j >= 1.5f && j < 3f)
                    {
                        i = 2f;
                    }
                    else if (j >= 3f && j < 5f)
                    {
                        i = Random.Range(3f, 5f);
                        flg = true;
                    }
                }
                else if (i >= 3f && i < 4f)
                {
                    if (j >= 1f && j < 1.5f)
                    {
                        i = 4f;
                    }
                    else if (j >= 1.5f && j < 3f)
                    {
                        i = 3f;
                    }
                    else if (j >= 3f && j < 5f)
                    {
                        i = Random.Range(1f, 2.9f);
                        flg = true;
                    }
                }
                else if (i >= 4f && i <= 5f)
                {
                    if (j >= 1f && j < 1.5f)
                    {
                        i = 3f;
                    }
                    else if (j >= 1.5f && j < 3f)
                    {
                        i = 4f;
                    }
                    else if (j >= 3f && j < 5f)
                    {
                        i = Random.Range(1f, 2.9f);
                        flg = true;
                    }
                }
            }
            else
            {
                if (i >= 1f && i < 2f)
                {
                    i = 2f;
                }
                else if (i >= 2f && i < 3f)
                {
                    i = 1f;
                }
                else if (i >= 3f && i < 4f)
                {
                    i = 4f;
                }
                else if (i >= 4f && i <= 5f)
                {
                    i = 3f;
                }
                flg = false;
            }
            time = 0;
        }
    }
}
