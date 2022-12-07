using Photon.Pun;
using TMPro;
using UnityEngine;

public class RoomView : MonoBehaviourPunCallbacks
{
    [SerializeField] private TMP_Text _roomName;

    private void Awake()
    {
        Render();
    }

    public void Render()
    {
        _roomName.text = PhotonNetwork.CurrentRoom.Name;
    }
}
