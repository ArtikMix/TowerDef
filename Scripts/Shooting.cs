using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Transform house;
    private GameObject aim;
    private bool new_aim = true;
    [SerializeField] private GameObject standart_bullet, force_bullet, massive_bullet;
    private float pace;//количество выстрелов в минуту
    private int damage;
    [SerializeField] private enum Type
    {
        STANDART = 1,
        FORCE = 2,
        MASSIVE = 3
    }
    Type type;

    private void Awake()
    {
        house = GameObject.FindGameObjectWithTag("house").transform;
        if (type == Type.STANDART)
        {
            damage = 10;
            pace = 120;
        }
    }

    private void Update() 
    {
        if (type == Type.STANDART && new_aim == true)
        {
            Collider[] col = Physics.OverlapSphere(transform.position, 10f);
            for(int i = 0; i<100; i++)
            {
                if (i==99 || col[i].tag == "enemy")
                {
                    aim = col[i].gameObject;
                    new_aim = false;
                    StartCoroutine(Shoot());
                    break;
                }
            }
        }
        transform.LookAt(aim.transform.position);
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            switch (type)
            {
                case Type.STANDART:
                    GameObject bullet = Instantiate(standart_bullet, transform.position, transform.rotation);
                    bullet.GetComponent<Bullet>().SetParametrs(damage, aim);
                    break;
            }
            yield return new WaitForSeconds(60/pace);
        }
    }
}
