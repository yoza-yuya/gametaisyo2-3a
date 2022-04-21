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
    void Start()
    {

    }

    void Update()
    {
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject Target = GameObject.Find("Player");
            var diff = Player.position - Enemy.position;
            var direction = diff.normalized;
            dis = Vector3.Distance(Enemy.position, Player.position);
            if (Physics.Raycast(Enemy.position, direction, out hit, dis))
            {
                Ray ray = new Ray(Enemy.position, direction);
                Debug.DrawRay(ray.origin, ray.direction * 20, Color.red, 5.0f);
                if (hit.transform.gameObject == Target) {
                    flag = true;
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
