using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

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
            if (manager.CheckMoney(150))
            {
                manager.AwayMoney(150);
                Debug.Log("buy_standart");
                Vector3 pos = new Vector3(active_cube.position.x, 0f, active_cube.position.z);
                Quaternion qua = new Quaternion(0, 45f, 0, 0);
                GameObject g = PhotonNetwork.Instantiate(standart.name, pos, qua);
                g.transform.GetChild(3).transform.GetChild(0).GetComponent<Shooting>().type = Shooting.Type.STANDART;
                g.transform.SetParent(active_cube);
                gameObject.SetActive(false);
            }

    }

    public void BuyForce()
    {
        if (manager.CheckMoney(200))
        {
            manager.AwayMoney(200);
            Debug.Log("buy_force");
            Vector3 pos = new Vector3(active_cube.position.x, 0f, active_cube.position.z);
            Quaternion qua = new Quaternion(0, 45f, 0, 0);
            GameObject g = PhotonNetwork.Instantiate(force.name, pos, qua);
            g.transform.GetChild(3).transform.GetChild(0).GetComponent<Shooting>().type = Shooting.Type.FORCE;
            g.transform.SetParent(active_cube);
            gameObject.SetActive(false);
        }
    }

    public void BuyMassive()
    {
        if (manager.CheckMoney(300))
        {
            manager.AwayMoney(300);
            Debug.Log("buy_massive");
            Vector3 pos = new Vector3(active_cube.position.x, 0f, active_cube.position.z);
            Quaternion qua = new Quaternion(0, 45f, 0, 0);
            GameObject g = PhotonNetwork.Instantiate(massive.name, pos, qua);
            g.transform.GetChild(3).transform.GetChild(0).GetComponent<Shooting>().type = Shooting.Type.MASSIVE;
            g.transform.SetParent(active_cube);
            gameObject.SetActive(false);
        }
    }
}
