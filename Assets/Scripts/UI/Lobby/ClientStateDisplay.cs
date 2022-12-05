using Photon.Realtime;
using TMPro;
using UnityEngine;

namespace Com.Daridakr.RPWorld
{
    [RequireComponent(typeof(TMP_Text))]
    public class ClientStateDisplay : MonoBehaviour
    {
        [SerializeField] private Launcher _source;

        private TMP_Text _display;

        private void OnEnable()
        {
            _source.OnStateChanged += OnClientStateChanged;
        }

        private void OnDisable()
        {
            _source.OnStateChanged -= OnClientStateChanged;
        }

        private void Awake()
        {
            _display = GetComponent<TMP_Text>();
        }

        private void OnClientStateChanged(ClientState state)
        {
            switch (state)
            {
                case ClientState.ConnectingToNameServer:
                    _display.text = $"Подключение к серверу...";
                    break;
                case ClientState.JoiningLobby:
                    _display.text = $"Подключение к лобби...";
                    break;
                case ClientState.JoinedLobby:
                    _display.text = $"Вы подключены.";
                    _display.color= Color.green;
                    break;
                case ClientState.Disconnected:
                    _display.text = $"Нет подключения.";
                    _display.color = Color.red;
                    break;
            }
        }
    }
}