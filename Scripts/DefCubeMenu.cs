using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefCubeMenu : MonoBehaviour
{
    [HideInInspector]
    public Transform active_cube;
    GameManager manager;
    [SerializeField] private GameObject standart, massive, force;

    private void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }
    private void Update()
    {
        //transform.LookAt(GameObject.FindGameObjectWithTag("MainCamera").transform);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void BuyStandart()
    {
        //if (manager.money >= 150)
        //{
        //manager.AwayMoney(150);
            Debug.Log("buy_standart");
            Vector3 pos = new Vector3(active_cube.position.x, 0f, active_cube.position.z);
            Quaternion qua = new Quaternion(0, 45f, 0, 0);
            GameObject g = Instantiate(standart, pos, qua);
            g.transform.SetParent(active_cube);
            gameObject.SetActive(false);
       // }
    }

    public void BuyForce()
    {
        if (manager.money >= 200)
        {
            manager.AwayMoney(200);
            Debug.Log("buy_force");
            Vector3 pos = new Vector3(active_cube.position.x, 0f, active_cube.position.z);
            Quaternion qua = new Quaternion(0, 45f, 0, 0);
            GameObject g = Instantiate(force, pos, qua);
            g.transform.SetParent(active_cube);
            gameObject.SetActive(false);
        }
    }

    public void BuyMassive()
    {
        if (manager.money >= 300)
        {
            manager.AwayMoney(300);
            Debug.Log("buy_massive");
            Vector3 pos = new Vector3(active_cube.position.x, 0f, active_cube.position.z);
            Quaternion qua = new Quaternion(0, 45f, 0, 0);
            GameObject g = Instantiate(massive, pos, qua);
            g.transform.SetParent(active_cube);
            gameObject.SetActive(false);
        }
    }
}
