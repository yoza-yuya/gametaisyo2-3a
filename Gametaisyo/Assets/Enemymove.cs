using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemymove : MonoBehaviour
{
    [SerializeField]
    [Tooltip("巡回する地点の配列")]
    private Transform[] waypoints;
    private NavMeshAgent _agent;
    EnemyDetection ene3;
    public Transform target;
    public int Size = 33;
    public GameObject Sphere;
    private float CoolTime;
    private bool AttackFlag = false;
    public bool WarpFlag = false;
    // 現在の目的地
    private int point = 0;
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.SetDestination(waypoints[0].position);
    }

    // Update is called once per frame
    void Update()
    {
        if (AttackFlag == false)
        {
            ene3 = Sphere.GetComponent<EnemyDetection>();
            if (ene3.flag == false)
            {
                if (_agent.remainingDistance <= _agent.stoppingDistance)
                {
                    point = (point + 1) % waypoints.Length;
                    _agent.SetDestination(waypoints[point].position);
                }
            }
            else if (ene3.flag == true)
            {
                _agent.SetDestination(target.position);
            }
        }
        else if (AttackFlag == true)
        {
            CoolTime += Time.deltaTime;
            if (CoolTime >= 5f)
            {
                AttackFlag = false;
                WarpFlag = false;
                point = Random.Range(0, Size);
                _agent.SetDestination(waypoints[point].position);
                _agent.speed = 3.5f;
                CoolTime = 0f;
            }
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            WarpFlag = true;
            Debug.Log("当たった");
            _agent.speed = 0f;
            AttackFlag = true;
        }
        if (other.gameObject.tag == "Bullet")
        {
            this.transform.position = waypoints[Random.Range(0,Size)].position;
        }
    }
}