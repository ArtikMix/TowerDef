using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportCubeMenu : MonoBehaviour
{
    GameManager manager;
    [SerializeField] private GameObject sup_b;

    private void Start()
    {
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
            //Instantiate(sup_b, )
        }
    }
}
