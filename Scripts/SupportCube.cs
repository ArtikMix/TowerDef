using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SupportCube : MonoBehaviour, IPointerClickHandler
{
    private GameObject support_menu;

    void Awake()
    {
        support_menu = GameObject.FindGameObjectWithTag("sup_menu");
    }

    public void OnPointerClick(PointerEventData data)
    {
        support_menu.SetActive(true);
    }
}
