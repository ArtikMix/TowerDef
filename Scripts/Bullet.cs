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
        Vector3.MoveTowards(transform.position, aim.transform.position, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            //other.GetComponent<EnemyLogic>(). минус хп
        }
    }

    public void SetParametrs(int d, GameObject a)
    {
        aim = a;
        damage = d;
    }
}
