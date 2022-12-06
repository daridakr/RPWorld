using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.Events;

namespace Com.Daridakr.RPWorld
{
    public class Launcher : MonoBehaviourPunCallbacks
    {
        private string _gameVersion = "1";

        public event UnityAction<ClientState> OnStateChanged;

        private void Awake()
        {
            PhotonNetwork.AutomaticallySyncScene = true;
        }

        private void Start()
        {
            ConnectToMaster();
        }

        public void ConnectToMaster()
        {
            PhotonNetwork.ConnectUsingSettings();
            PhotonNetwork.GameVersion = _gameVersion;

            OnStateChanged?.Invoke(PhotonNetwork.NetworkClientState);
        }

        public override void OnConnectedToMaster()
        {
            PhotonNetwork.JoinLobby();

            OnStateChanged?.Invoke(PhotonNetwork.NetworkClientState);
        }

        public override void OnJoinedLobby()
        {
            OnStateChanged?.Invoke(PhotonNetwork.NetworkClientState);
        }

        public override void OnDisconnected(DisconnectCause cause)
        {
            Debug.Log(PhotonNetwork.NetworkClientState);
            OnStateChanged?.Invoke(PhotonNetwork.NetworkClientState);
        }  
    }
}