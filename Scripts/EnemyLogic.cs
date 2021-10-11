using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyLogic : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform house;
    [SerializeField] private GameObject death_GX;
    public int health;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        house = GameObject.FindGameObjectWithTag("house").transform;
    }

    void Update()
    {
        agent.SetDestination(house.position);
    }

    public void SetHealth(int h)
    {
        health -= h;
        if (health <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        Instantiate(death_GX, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
