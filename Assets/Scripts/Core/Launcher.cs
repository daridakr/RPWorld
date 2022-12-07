using IJunior.TypedScenes;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.Events;

namespace Com.Daridakr.RPWorld
{
    public class Launcher : MonoBehaviourPunCallbacks
    {
        private string _gameVersion = "1";

        public event UnityAction ConnectingToMaster;
        public event UnityAction JoiningLobby;
        public event UnityAction JoinedLobby;
        public event UnityAction Disconnected;

        private void Awake()
        {
            PhotonNetwork.AutomaticallySyncScene = true;
        }

        private void Start()
        {
            if (PhotonNetwork.IsConnected)
            {
                JoinedLobby.Invoke();
                return;
            }

            ConnectToMaster();
        }

        public void ConnectToMaster()
        {
            PhotonNetwork.ConnectUsingSettings();
            ConnectingToMaster.Invoke();
            PhotonNetwork.GameVersion = _gameVersion;
        }

        public override void OnConnectedToMaster()
        {
            PhotonNetwork.JoinLobby();
            JoiningLobby.Invoke();
        }

        public override void OnJoinedLobby()
        {
            JoinedLobby.Invoke();
        }

        public override void OnDisconnected(DisconnectCause cause)
        {
            Disconnected.Invoke();
            ErrorWindow.Load(cause.ToString());
        }
    }
}