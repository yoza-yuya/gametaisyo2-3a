using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    CharacterController Controller;
    Transform Target;
    GameObject Player;
    bool InArea = false;
    void Start()
    {

        // プレイヤータグの取得
        Player = GameObject.FindWithTag("Player");
        Target = Player.transform;

        Controller = GetComponent<CharacterController>();

    }  
    private void Update()
    {

        if (InArea)
        {
            // プレイヤーのほうを向かせる
            this.transform.LookAt(Target.transform);

            // キューブとプレイヤー間の距離を計算
            Vector3 direction = Target.position - this.transform.position;
            direction = direction.normalized;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            InArea = true;
        }
    }
    
}
