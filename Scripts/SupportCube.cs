using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SupportCube : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject support_menu;
    public void OnPointerClick(PointerEventData data)
    {
        support_menu.SetActive(true);
    }
}
