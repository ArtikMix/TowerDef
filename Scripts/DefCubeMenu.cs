using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefCubeMenu : MonoBehaviour
{
    [SerializeField] private GameObject shop_menu;
    public void Active(string cube)
    {
        GameObject dc = null;
        GameObject[] def_cubes = GameObject.FindGameObjectsWithTag("def_cube");
        foreach(GameObject d in def_cubes)
        {
            if (d.transform.name == cube)
            {
                dc = d;
                break;
            }
        }
        shop_menu.SetActive(true);
        Vector3 pos = new Vector3(dc.transform.position.x, dc.transform.position.y + 2f, dc.transform.position.z);
        shop_menu.transform.position = pos;
    }

    private void Update()
    {
        if (shop_menu.activeInHierarchy)
        {
            shop_menu.transform.LookAt(GameObject.FindGameObjectWithTag("MainCamera").transform.position);
        }
    }

    public void Close()
    {
        
    }
}
