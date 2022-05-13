using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyDetection : MonoBehaviour
{
    public bool flag = false;
    public Transform Player;
    public Transform Enemy;
    private RaycastHit hit;
    float dis;
    Vector3 pos;
    void Start()
    {
        pos = Enemy.position;
    }

    void Update()
    {
        pos.y = 0;
        pos = Enemy.position;
        Debug.Log(Enemy.position.y);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject Target = GameObject.Find("Player");
            Vector3 diff = Player.position - Enemy.position;
            Vector3 direction = diff.normalized;
            dis = Vector3.Distance(Enemy.position, Player.position);
            Ray ray = new Ray(Enemy.position, direction);
            Debug.DrawRay(ray.origin, ray.direction * dis, Color.red);

            if (Physics.Raycast(ray.origin, ray.direction * dis, out hit))
            {
                if (hit.collider.CompareTag("Player"))
                {
                    Debug.Log("プレイヤー発見");
                    flag = true;
                }
                else
                {
                    Debug.Log("プレイヤーとの間に壁がある");
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            flag = false;
        }
    }
}