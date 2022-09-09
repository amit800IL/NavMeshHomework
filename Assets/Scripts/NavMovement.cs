using UnityEngine;
using UnityEngine.AI;


public class NavMovement : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] targetDestinations;
    int currentWayPointIndex = 0;
    public float minDistanceForNextWayPoint;

    public bool looping = true;
    private bool finishedRoute = false;

    public void Start()
    {
        GoToWayPoint();
    }

    private void Update()
    {
        
        if (navMeshAgent.remainingDistance <= minDistanceForNextWayPoint)
        {
                GoToWayPoint();
            

        }
    }
    void GoToWayPoint()
    {
        navMeshAgent.SetDestination(targetDestinations[currentWayPointIndex].position);
        currentWayPointIndex++;

        if (currentWayPointIndex >= targetDestinations.Length)
        {
            if (looping)
            {
                currentWayPointIndex = 0;
            }

            else
            {
                finishedRoute = true;
            }
        }
    }
}
