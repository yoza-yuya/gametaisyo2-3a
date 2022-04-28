using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalOpen : MonoBehaviour
{

    public GameObject goalwall;
    int GoalCount = 0;
    public GameObject Goal;
    public void Update()
    {
        GoalCount = ItemTakeRost.GoalCount;
        //五つ取ったら
        if (GoalCount == 5)
        {
            Destroy(goalwall);
        }
    }
}
