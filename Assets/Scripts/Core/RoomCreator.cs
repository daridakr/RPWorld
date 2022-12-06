using IJunior.TypedScenes;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;
using WebSocketSharp;

namespace Com.Daridakr.RPWorld
{
    public class RoomCreator : MonoBehaviourPunCallbacks
    {
        [SerializeField] private TMP_InputField _title;
        [SerializeField] private RoomOptions _options;

        public void Create()
        {
            if (_title.text.IsNullOrEmpty())
            {
                return;
            }

            PhotonNetwork.CreateRoom(_title.text);
        }

        public override void OnJoinedRoom()
        {
            IJunior.TypedScenes.Room.Load();
        }

        public override void OnCreateRoomFailed(short returnCode, string message)
        {
            ErrorWindow.Load();
        }
    }
}