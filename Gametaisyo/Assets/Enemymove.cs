using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemymove : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent _agent;
    Vector3 rot;
    Vector3 pos;
    EnemyTurn2 ene2;
    EnemyDetection ene3;
    public GameObject Sphere;
    public GameObject Cube;
    float SpeedX = 3f;
    float SpeedZ = 0f;
    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        pos = transform.position;
        rot = transform.eulerAngles;
    }
    void Update()
    {
        ene2 = Cube.GetComponent<EnemyTurn2>();
        ene3 = Sphere.GetComponent<EnemyDetection>();
        if (ene3.flag == false) {
            pos.x += SpeedX * Time.deltaTime;
            pos.z += SpeedZ * Time.deltaTime;
            transform.position = pos;
            if (ene2.i >= 1f && ene2.i < 2f)
            {
                rot.y = 0;
                transform.eulerAngles = rot;
                SpeedX = 5f;
                SpeedZ = 0f;
            }
            else if (ene2.i >= 2f && ene2.i < 3f)
            {
                rot.y = 180;
                transform.eulerAngles = rot;
                SpeedX = -5f;
                SpeedZ = 0f;
            }
            else if (ene2.i >= 3f && ene2.i < 4f)
            {
                rot.y = 270;
                transform.eulerAngles = rot;
                SpeedX = 0f;
                SpeedZ = 5f;
            }
            else if (ene2.i >= 4f && ene2.i <= 5f)
            {
                rot.y = 90;
                transform.eulerAngles = rot;
                SpeedX = 0f;
                SpeedZ = -5f;
            }
        }
        else if (ene3.flag == true)
        {
            _agent.destination = target.position;
            pos = this.gameObject.transform.position;
        }
    }
}
