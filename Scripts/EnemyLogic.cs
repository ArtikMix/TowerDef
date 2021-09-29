using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyLogic : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] private Transform house;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        house = GameObject.FindGameObjectWithTag("house").transform;
        agent.speed = 2f;
        agent.stoppingDistance = 0.5f;
    }

    private void Update()
    {
        agent.SetDestination(house.position);
    }
}
