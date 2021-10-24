using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    [SerializeField] private Text log;
    [SerializeField] private Text enter;
    [SerializeField] private GameObject re;

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
        PhotonNetwork.CreateRoom("Room" + roomNumber, new Photon.Realtime.RoomOptions { MaxPlayers = 2 });
        PhotonNetwork.LoadLevel("Game_1");
    }

    public void JoinRoom()
    {
        Log("Connecting to room: " + enter.text);
        PhotonNetwork.JoinRoom(enter.text);
    }

    public override void OnCreatedRoom()
    {
        Log("Room created");
    }

    public override void OnJoinedRoom()
    {
        Log("Joined to room");
        PhotonNetwork.LoadLevel("Game_1");
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Log("Creating room failed");
    }

    public void Activate()
    {
        re.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
