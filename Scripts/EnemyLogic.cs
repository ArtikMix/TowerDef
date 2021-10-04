using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyLogic : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform house;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        house = GameObject.FindGameObjectWithTag("house").transform;
    }

    void Update()
    {
        agent.SetDestination(house.position);
    }
}
