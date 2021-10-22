using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SupportBuilding : MonoBehaviour, IPointerClickHandler
{
    public int damage;
    public int pace;
    [SerializeField] private GameObject menu;

    void Start()
    {

    }

    public void OnPointerClick(PointerEventData data)
    {
        menu.SetActive(true);
        menu.GetComponent<SupportBuildingMenu>().SetInfo(damage, pace, this);
    }

    
}
