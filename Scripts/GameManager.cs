using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int money;

    public void AddMoney(int m)
    {
        money += m;
    }

    public void AwayMoney(int m)
    {
        money -= m;
    }
}
