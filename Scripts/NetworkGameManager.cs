using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class NetworkGameManager : MonoBehaviourPunCallbacks
{
    bool once = true;
    [SerializeField] private GameObject waiting;
    //[SerializeField] private GameObject player_1, player_2;

    private void Start()
    {
        Time.timeScale = 0f;
        /*if (PhotonNetwork.PlayerList.Length == 1)
        {
            PhotonNetwork.Instantiate(player_1.name, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
        }
        else if (PhotonNetwork.PlayerList.Length == 2)
        {
            PhotonNetwork.Instantiate(player_2.name, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
        }*/

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
