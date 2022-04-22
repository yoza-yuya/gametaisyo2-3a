using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurn : MonoBehaviour
{
    public int flg = 0;
    public float a = 0f;
    float j = 0;
    EnemyTurn2 ene;
    public GameObject Cube;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ene = Cube.GetComponent<EnemyTurn2>();
        if(ene.flg3 == 1)
        {
            flg = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "T")
        {
            a = ene.i;
            flg = 1;
            j = Random.Range(1f, 4f);
            if(j >= 1f && j < 2.5f)
            {
                if (a >= 1f && a < 2f)
                {
                    a = 1f;
                }
                else if (a >= 2f && a < 3f)
                {
                    a = 2f;
                }
                else if (a >= 3f && a < 4f)
                {
                    a = 1f;
                }
            }
            else if (j >= 2.5f && j < 4f)
            {
                if (a >= 1f && a < 2f)
                {
                    a = 4f;
                }
                else if (a >= 2f && a < 3f)
                {
                    a = 4f;
                }
                else if (a >= 3f && a < 4f)
                {
                    a = 2f;
                }
            }
        }
        if (other.gameObject.tag == "OppositeT")
        {
            a = ene.i;
            flg = 1;
            j = Random.Range(1f, 4f); 
            if (j >= 1f && j < 2.5f)
            {
                if (a >= 1f && a < 2f)
                {
                    a = 1f;
                }
                else if (a >= 2f && a < 3f)
                {
                    a = 2f;
                }
                else if (a >= 4f && a <= 5f)
                {
                    a = 1f;
                }
            }
            else if (j >= 2.5f && j < 4f)
            {
                if (a >= 1f && a < 2f)
                {
                    a = 3f;
                }
                else if (a >= 2f && a < 3f)
                {
                    a = 3f;
                }
                else if (a >= 4f && a <= 5f)
                {
                    a = 2f;
                }
            }
        }
        if (other.gameObject.tag == "To")
        {
            a = ene.i;
            flg = 1;
            j = Random.Range(1f, 4f);
            if (j >= 1f && j < 2.5f)
            {
                if (a >= 1f && a < 2f)
                {
                    a = 3f;
                }
                else if (a >= 3f && a < 4f)
                {
                    a = 3f;
                }
                else if ( a >= 4f && a <= 5f)
                {
                    a = 4f;
                }
            }
            else if (j >= 2.5f && j < 4f)
            {
                if (a >= 1f && a < 2f)
                {
                    a = 4f;
                }
                else if (a >= 3f && a < 4f)
                {
                    a = 1f;
                }
                else if (a >= 4f && a <= 5f)
                {
                    a = 1f;
                }
            }
            Debug.Log(a);
        }
        if (other.gameObject.tag == "OppositeTo")
        {
            a = ene.i;
            flg = 1;
            j = Random.Range(1f, 4f);
            if (j >= 1f && j < 2.5f)
            {
                if (a >= 2f && a < 3f)
                {
                    a = 3f;
                }
                else if (a >= 3f && a < 4f)
                {
                    a = 3f;
                }
                else if (a >= 4f && a <= 5f)
                {
                    a = 4f;
                }
            }
            else if (j >= 2.5f && j < 4f)
            {
                if (a >= 2f && a < 3f)
                {
                    a = 4f;
                }
                else if (a >= 3f && a < 4f)
                {
                    a = 2f;
                }
                else if (a >= 4f && a <= 5f)
                {
                    a = 2f;
                }
            }

        }
        if (other.gameObject.tag == "Cross")
        {
            a = ene.i;
            Debug.Log("十字");
            flg = 1;
            j = Random.Range(1f, 4f);
        }
    }
}
