using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportCubeMenu : MonoBehaviour
{
    GameManager manager;
    [SerializeField] private GameObject sup_b;
    private Vector3 pos;

    private void Start()
    {
        gameObject.SetActive(false);
        manager = FindObjectOfType<GameManager>();
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void Buy()
    {
        if (manager.CheckMoney(350))
        {
            manager.AwayMoney(350);
            Instantiate(sup_b, pos, Quaternion.identity);
        }
    }

    public void SetInstantiatePosition(Vector3 p)
    {
        pos = p;
    }
}
