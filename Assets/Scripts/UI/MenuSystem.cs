using IJunior.TypedScenes;
using Photon.Pun;
using UnityEngine;

namespace Com.Daridakr.RPWorld
{
    public class MenuSystem : MonoBehaviour
    {
        public void OnCreateRoomButtonClick()
        {
            RoomCreating.Load();
        }

        public void OnLeaveRoomButtonClick()
        {
            PhotonNetwork.LeaveRoom(this);
            OnBackToLobbyButtonClick();
        }

        public void OnBackToLobbyButtonClick()
        {
            Lobby.Load();
        }

        public void OnExitAppButtonClick()
        {
            Application.Quit();
        }
    }
}