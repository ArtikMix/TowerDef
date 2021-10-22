using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int money;

    public void AddMoney(int m)
    {
        money += m;
    }

    public void AwayMoney(int m)
    {
        money -= m;
    }

    public bool CheckMoney(int m)
    {
        if (money >= m)
            return true;
        else
            return false;
    }
}
