using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetworkGrab : MonoBehaviour
{
    private PhotonView photonView;
    void Start()
    {
        photonView = GetComponent<PhotonView>();
    }

    public void ChangeOwnership()
    {
        photonView.RequestOwnership();
    }
}
