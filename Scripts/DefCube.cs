using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DefCube : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject menu;
    void Start()
    {
        //menu = GameObject.FindGameObjectWithTag("def_menu");
        //menu.SetActive(false);
    }

    public void OnPointerClick(PointerEventData data)
    {
        if (transform.childCount == 0)
        {
            Active();
        }
    }

    public void Active()
    {
        menu.SetActive(true);
        menu.transform.position = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
        menu.GetComponent<DefCubeMenu>().active_cube = transform;
    }
}
