using IJunior.TypedScenes;
using TMPro;
using UnityEngine;

namespace Com.Daridakr.RPWorld
{
    [RequireComponent(typeof(TMP_Text))]
    public class ErrorMessageDisplay : MonoBehaviour, ISceneLoadHandler<string>
    {
        private TMP_Text _display;

        public void OnSceneLoaded(string argument)
        {
            _display = GetComponent<TMP_Text>();
            _display.text = argument;
        }
    }
}