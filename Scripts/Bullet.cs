using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject aim;
    private int damage;
    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        //Vector3.MoveTowards(transform.position, aim.transform.position, 10f*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            other.GetComponent<EnemyLogic>().SetHealth(damage);
        }
    }

    public void SetParametrs(int d, GameObject a)
    {
        aim = a;
        damage = d;
    }
}
