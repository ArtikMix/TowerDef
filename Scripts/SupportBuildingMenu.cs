using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SupportBuildingMenu : MonoBehaviour
{
    [SerializeField] private Text info;
    private SupportBuilding SB;
    GameManager manager;

    private void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }

    public void SetInfo(int d, int p, SupportBuilding sb)
    {
        info.text = "Damage buff = " + d.ToString() + "\nPace buff = " + p.ToString();
        SB = sb;
    }

    private void UpDamageBuff()
    {
        if (manager.CheckMoney(50))
        {
            manager.AwayMoney(50);
            SB.damage += 5;
        }
    }

    private void UpPaceBuff()
    {
        if (manager.CheckMoney(100))
        {
            manager.AwayMoney(100);
            SB.pace += 2;
        }
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
