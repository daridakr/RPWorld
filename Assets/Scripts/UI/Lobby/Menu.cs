using IJunior.TypedScenes;
using UnityEngine;

namespace Com.Daridakr.RPWorld
{
    public class Menu : MonoBehaviour
    {
        public void OnCreateRoomButtonClick()
        {
            RoomCreating.Load();
        }

        public void OnExitButtonClick()
        {
            Application.Quit();
        }
    }
}