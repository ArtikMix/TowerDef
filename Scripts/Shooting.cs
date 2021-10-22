using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Transform house;
    private GameObject aim;
    private bool new_aim = true;
    [SerializeField] private GameObject standart_bullet;
    private float pace;//количество выстрелов в минуту
    private int damage;
    private bool shoot = true;
    public enum Type
    {
        STANDART = 1,
        FORCE = 2,
        MASSIVE = 3
    }
    public Type type;

    private void Awake()//
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
        if (aim == null)
        {
            new_aim = true;
        }
        if (type == Type.STANDART && new_aim == true)
        {
            Collider[] col = Physics.OverlapSphere(transform.position, 15f);
            for(int i = 0; i<col.Length; i++)
            {
                if (col[i].tag == "enemy")
                {
                    aim = col[i].gameObject;
                    new_aim = false;
                    StartCoroutine(Shoot());
                    break;
                }
            }
            if (aim == null)
                shoot = false;
            else if (aim != null)
                shoot = true;
        }
        if (type == Type.FORCE && new_aim == true)
        {
            Collider[] col = Physics.OverlapSphere(transform.position, 15f);
            for (int i = 0; i < col.Length; i++)
            {
                if (col[i].GetComponent<EnemyLogic>().health > 100)
                {
                    aim = col[i].gameObject;
                    new_aim = false;
                    StartCoroutine(Shoot());
                    break;
                }
            }
        }  
        if (type == Type.MASSIVE && new_aim == true)
        {
            Collider[] col = Physics.OverlapSphere(transform.position, 10f);
            for (int i = 0; i < col.Length; i++)
            {
                if (col[i].tag == "enemy")
                {
                    aim = col[i].gameObject;
                    new_aim = false;
                    StartCoroutine(Shoot());
                    break;
                }
            }
        }
        if (aim!=null)
            transform.LookAt(aim.transform.position);//селжение за монстром, по которому ведётся огонь
    }

    IEnumerator Shoot()
    {
        while (shoot)
        {
            switch (type)
            {
                case Type.STANDART:
                    GameObject bullet0 = Instantiate(standart_bullet, transform.position, transform.rotation);
                    bullet0.GetComponent<Bullet>().SetParametrs(damage, aim);
                    break;
                case Type.FORCE:
                    GameObject bullet1 = Instantiate(standart_bullet, transform.position, transform.rotation);
                    bullet1.GetComponent<Bullet>().SetParametrs(damage, aim);
                    break;
                case Type.MASSIVE:
                    GameObject bullet2 = Instantiate(standart_bullet, transform.position, transform.rotation);
                    bullet2.GetComponent<Bullet>().SetParametrs(damage, aim);
                    break;
            }
            yield return new WaitForSeconds(60/pace);
        }
    }
}
