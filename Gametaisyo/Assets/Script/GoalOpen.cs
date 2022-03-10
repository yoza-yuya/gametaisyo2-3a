using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalOpen : MonoBehaviour
{
    int GoalCount = 0;
    public GameObject Goal;
    public void Goalflg()
    {
        //アイテムが取られるとカウントを増やす
        GoalCount++;
        Debug.Log(GoalCount);
        //五つ取ったら
        if(GoalCount == 5)
        {
            Goal.SetActive(false);
        }
    }
}
