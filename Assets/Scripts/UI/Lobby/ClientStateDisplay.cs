using TMPro;
using UnityEngine;

namespace Com.Daridakr.RPWorld
{
    [RequireComponent(typeof(TMP_Text))]
    public class ClientStateDisplay : MonoBehaviour
    {
        [SerializeField] private Launcher _source;

        private TMP_Text _display;

        private void Awake()
        {
            _display = GetComponent<TMP_Text>();
        }

        private void OnEnable()
        {
            _source.ConnectingToMaster += OnConnectedToMaster;
            _source.JoiningLobby += OnJoiningLobby;
            _source.JoinedLobby += OnJoinedLobby;
            _source.Disconnected += OnDisconnected;
        }

        private void OnDisable()
        {
            if (_source != null)
            {
                _source.ConnectingToMaster -= OnConnectedToMaster;
                _source.JoiningLobby -= OnJoiningLobby;
                _source.JoinedLobby -= OnJoinedLobby;
                _source.Disconnected -= OnDisconnected;
            }
        }

        public void OnConnectedToMaster()
        {
            _display.text = $"����������� � �������...";
        }

        public void OnJoiningLobby()
        {
            _display.text = $"����������� � �����...";
        }

        public void OnJoinedLobby()
        {
            _display.text = $"�� ����������.";
            _display.color = Color.green;
        }

        public void OnDisconnected()
        {
            _display.text = $"��� �����������.";
            _display.color = Color.red;
        }
    }
}