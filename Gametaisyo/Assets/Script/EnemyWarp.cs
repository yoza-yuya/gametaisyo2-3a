using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyWarp : MonoBehaviour
{
    public GameObject Enemy;
    [Tooltip("ワープポイント")]
    public Transform[] waypoints2;
    Enemymove ene;
    private bool WarpFlag2;
    private bool warpflag;
    private int num;
    public int Size2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        WarpFlag2 = true;
    }

    // Update is called once per frame
    void Update()
    {
        ene = Enemy.GetComponent<Enemymove>();
        warpflag = ene.WarpFlag;
        if (warpflag == false)
        {
            WarpFlag2 = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (WarpFlag2 == true)
        {
            if (warpflag == true)
            {
                if (other.gameObject.tag == "Player")
                {
                    num = Random.Range(0, Size2);
                    Enemy.transform.position = waypoints2[num].position;
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (WarpFlag2 == true)
        {
            if (other.gameObject.tag == "Player")
            {
                WarpFlag2 = false;
            }
        }
    }
}
