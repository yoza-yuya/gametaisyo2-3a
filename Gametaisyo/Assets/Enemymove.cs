using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemymove : MonoBehaviour
{
    [SerializeField]
    [Tooltip("巡回する地点の配列")]
    private Transform[] waypoints;
    [Tooltip("巡回する地点の配列2")]
    private Transform[] waypoints2;
    private NavMeshAgent _agent;
    EnemyDetection ene3;
    public Transform target;
    public GameObject Sphere;
    // 現在の目的地
    private int point;
    void Start()
    {
         _agent = GetComponent<NavMeshAgent>();
         _agent.SetDestination(waypoints[0].position);
    }

    // Update is called once per frame
    void Update()
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
}