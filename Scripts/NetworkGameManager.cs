using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class NetworkGameManager : MonoBehaviourPunCallbacks
{
    bool once = true;
    [SerializeField] private GameObject waiting;

    private void Start()
    {
        //Time.timeScale = 0f;
    }

    private void Update()
    {
        if (once && PhotonNetwork.PlayerList.Length == 2)
        {
            once = false;
            Time.timeScale = 1f;
            waiting.SetActive(false);
        }
        Debug.Log(PhotonNetwork.PlayerList.Length);
    }

    public void CopyRoom()
    {
        GUIUtility.systemCopyBuffer = PhotonNetwork.CurrentRoom.Name;
    }
}
