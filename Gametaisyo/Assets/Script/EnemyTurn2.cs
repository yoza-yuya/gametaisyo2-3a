using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurn2 : MonoBehaviour
{
    EnemyTurn ene;
    public GameObject Cap;
    public float i = 1f;
    public float j = 0f;
    int time = 0;
    bool flg = false;
    int flg2 = 0;
    public int flg3 = 0;
    private void Start()
    {

    }
    void Update()
    {
        ene = Cap.GetComponent<EnemyTurn>();
        flg2 = ene.flg;
        if (flg3 == 0)
        {
            if (flg2 == 1)
            {
                i = ene.a;
                flg3 = 1;
                Debug.Log(ene.a);
            }
        }
        if (ene.flg == 0)
        {
            flg3 = 0;
        }
        time += 1;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            if (time >= 5 || flg == false)
            {
                j = Random.Range(1f, 4f);
                if (i >= 1f && i < 2f)
                {
                    if (j >= 1f && j < 2.5f)
                    {
                        i = 1f;
                    }
                    else if (j >= 2.5f && j < 4f)
                    {
                        i = Random.Range(3f, 5f);
                        flg = true;
                    }
                }
                else if (i >= 2f && i < 3f)
                {
                    if (j >= 1f && j < 2.5f)
                    {
                        i = 2f;
                    }
                    else if (j >= 2.5f && j < 4f)
                    {
                        i = Random.Range(3f, 5f);
                        flg = true;
                    }
                }
                else if (i >= 3f && i < 4f)
                {
                    if (j >= 1f && j < 2.5f)
                    {
                        i = 3f;
                    }
                    else if (j >= 2.5f && j < 4f)
                    {
                        i = Random.Range(1f, 2.9f);
                        flg = true;
                    }
                }
                else if (i >= 4f && i <= 5f)
                {
                    if (j >= 1f && j < 2.5f)
                    {
                        i = 4f;
                    }
                    else if (j >= 2.5f && j < 4f)
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