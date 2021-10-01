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
        transform.LookAt(GameObject.FindGameObjectWithTag("MainCamera").transform);
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
}
