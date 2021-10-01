using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DefCube : MonoBehaviour, IPointerClickHandler
{
    DefCubeMenu menu;

    void Start()
    {
        menu = FindObjectOfType<DefCubeMenu>();
    }

    public void OnPointerClick(PointerEventData data)
    {
        if (transform.childCount == 0)
        {
            menu.Active(transform.name);
        }
    }
}
