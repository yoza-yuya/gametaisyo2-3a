using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyuukaku : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform target;

    // カーソル
    [SerializeField] Transform cursor;

    public ItemPoint itempoint;
    public bool YellowCount;
    bool isCalledOnce1 = false;

    // Update is called once per frame
    void Update()
    {
        YellowCount = itempoint.Getkyuukakucount();
        if (YellowCount == true)
        {
            if (!isCalledOnce1)
            {
                isCalledOnce1 = true;
                cursor.LookAt(target);
                StartCoroutine("GoalLood");
                //cursor.LookAt(target,10.0f);
            }
        }
    }


    IEnumerator GoalLood()
    {
        yield return new WaitForSeconds(10.0f);
        Destroy(cursor);
    }
}
