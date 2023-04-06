using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    void Start()
    {
        ConnectToServer();
    }

    void ConnectToServer()
    {
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("try connecting to server");
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("connected to server");
        base.OnConnectedToMaster();
        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 10;
        options.IsVisible = true;
        options.IsOpen = true;
        PhotonNetwork.JoinOrCreateRoom("room 1", options, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("joined the room");
        base.OnJoinedLobby();
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log("new player joined the room");
        base.OnPlayerEnteredRoom(newPlayer);
    }
}