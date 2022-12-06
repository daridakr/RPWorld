using Photon.Pun;
using TMPro;
using UnityEngine;

public class RoomView : MonoBehaviour
{
    [SerializeField] private TMP_Text _roomName;

    private void Awake()
    {
        Render();
    }

    public void Render()
    {
        // проверить существует ли такая комната
        _roomName.text = PhotonNetwork.CurrentRoom.Name;
    }
}
