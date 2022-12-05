using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace Com.Daridakr.RPWorld
{
    public class Launcher : MonoBehaviourPunCallbacks
    {
        private string gameVersion = "1";

        private void Awake()
        {
            PhotonNetwork.AutomaticallySyncScene = true;
        }

        private void Start()
        {
            Connect();
        }

        public void Connect()
        {
            PhotonNetwork.ConnectUsingSettings();
            PhotonNetwork.GameVersion = gameVersion;
        }

        public override void OnConnectedToMaster()
        {
            Debug.Log("PUN Basics Tutorial/Launcher: OnConnectedToMaster() was called by PUN");
        }


        public override void OnDisconnected(DisconnectCause cause)
        {
            Debug.LogWarningFormat("PUN Basics Tutorial/Launcher: OnDisconnected() was called by PUN with reason {0}", cause);
        }
    }
}