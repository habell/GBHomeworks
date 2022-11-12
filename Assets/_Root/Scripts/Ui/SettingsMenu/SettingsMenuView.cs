using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace _Root.Scripts.Ui.SettingsMenu
{
    internal class SettingsMenuView : MonoBehaviour
    {
        [SerializeField] private Button _buttonBack;


        public void Init(UnityAction backToMenu) =>
            _buttonBack.onClick.AddListener(backToMenu);

        public void OnDestroy() =>
            _buttonBack.onClick.RemoveAllListeners();
    }
}
