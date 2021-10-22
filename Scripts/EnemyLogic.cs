using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyLogic : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform house;
    [SerializeField] private GameObject death_GX;
    public int health = 100;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        house = GameObject.FindGameObjectWithTag("house").transform;
        agent.speed = 10f;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, house.position) >= 1f)
        {
            Debug.Log("Enemy " + transform.name + " far from house.");
            agent.SetDestination(house.position);
        } 
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
