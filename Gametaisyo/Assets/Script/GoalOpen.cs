using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalOpen : MonoBehaviour
{

    public GameObject goalwall;
    int GoalCount = 0;
    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public GameObject Wall4;
    public void Update()
    {
        GoalCount = ItemTakeRost.GoalCount;
        //五つ取ったら
        if (GoalCount == 1)
        {
            Destroy(Wall1);
        }
        else if (GoalCount == 2)
        {
            Destroy(Wall2);
        }else if (GoalCount == 3)
        {
            Destroy(Wall3);
        }else if (GoalCount == 4)
        {
            Destroy(Wall4);
        }else if (GoalCount == 5){
            Destroy(goalwall);
        }
    }
}
