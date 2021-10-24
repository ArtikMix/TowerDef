using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    [SerializeField] private Text log;
    private void Start()
    {
        PhotonNetwork.NickName = "Player" + Random.Range(100, 998);
        PhotonNetwork.GameVersion = "1";
        Log("Player name is set to: " + PhotonNetwork.NickName);
        Log("Game version is: " + PhotonNetwork.GameVersion);
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Log("Connected to master server");
    }

    public void Log(string message)
    {
        log.text = log.text + message + "\n";
        Debug.Log(message);
    }

    public void CreateGame()
    {
        Log("Creating room");
        int roomNumber = Random.Range(100, 998);

        PhotonNetwork.CreateRoom("Room" + roomNumber);
    }

    public override void OnCreatedRoom()
    {
        Log("Room created");
    }
}
