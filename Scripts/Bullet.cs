using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject aim;
    private int damage;
    private bool massive;
    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, aim.transform.position, 1f);
    }

    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            if (massive)
            {
                Collider[] col = Physics.OverlapSphere(other.transform.position, 10f);
                foreach (Collider c in col)
                {
                    c.GetComponent<EnemyLogic>().SetHealth(damage / 2);
                }
            }
            other.GetComponent<EnemyLogic>().SetHealth(damage);
        }
    }

    public void SetParametrs(int d, GameObject a)
    {
        aim = a;
        damage = d;
    }

    public void SetParametrs(int d, GameObject a, bool m)
    {
        aim = a;
        damage = d;
        massive = m;
    }
}
