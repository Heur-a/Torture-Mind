using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent navMeshAgent;

    public Transform[] destinations;

    public float distanceToFollowPath = 2;

    private int i = 0;

    void Start()
    {
        navMeshAgent.destination = destinations[0].transform.position;
    }


    void Update()
    {
        navMeshAgent.destination = destinations[i].position;

        if (Vector3.Distance(transform.position, destinations[i].position) <= distanceToFollowPath)
        {
            if (destinations[i] != destinations[destinations.Length - 1])
            {
                i++;
            }
            else
            {
                i = 0;
            }
        }
    }
}
