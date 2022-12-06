using Photon.Pun;
using UnityEngine;

namespace Com.Daridakr.RPWorld
{
    public class Lobby : MonoBehaviourPunCallbacks
    {
        public void CreateRoom()
        {

        }

        public override void OnCreateRoomFailed(short returnCode, string message)
        {
            Debug.Log("tried to create a room but failed. there must already be a room with that name");
            CreateRoom();
        }

        public override void OnJoinedRoom()
        {
            Debug.Log("room joined");
        }
    }
}