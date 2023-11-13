using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public WaypointManager waypointManager;

    NavMeshAgent meshAgent;

    public bool aggresive;

    int currentIndex;
    int currentLap;

    // Start is called before the first frame update
    void Start()
    {
        meshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!meshAgent.pathPending) 
        {
            if (meshAgent.remainingDistance <= meshAgent.stoppingDistance) 
            {
                currentIndex++;
            }

            if (currentIndex == waypointManager.Waypoints.Count) 
            {
                currentIndex = 0;
            }
        }

        
        meshAgent.SetDestination(waypointManager.Waypoints[currentIndex].position);
        
    }
}
