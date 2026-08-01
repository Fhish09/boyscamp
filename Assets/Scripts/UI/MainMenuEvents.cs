using UnityEngine;

namespace Boyscamp.UI
{
    // Simple event hub so different UI parts can talk without tight coupling
    public class MainMenuEvents : MonoBehaviour
    {
        public static MainMenuEvents Instance;

        public System.Action OnDeployPressed;
        public System.Action OnLoadoutOpened;
        public System.Action OnStoreOpened;
        public System.Action OnSettingsOpened;
        public System.Action OnBattlePassOpened;
        public System.Action OnClanOpened;

        void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
        }

        public void TriggerDeploy()
        {
            OnDeployPressed?.Invoke();
        }

        public void TriggerLoadout()
        {
            OnLoadoutOpened?.Invoke();
        }

        public void TriggerStore()
        {
            OnStoreOpened?.Invoke();
        }

        public void TriggerSettings()
        {
            OnSettingsOpened?.Invoke();
        }

        public void TriggerBattlePass()
        {
            OnBattlePassOpened?.Invoke();
        }

        public void TriggerClan()
        {
            OnClanOpened?.Invoke();
        }
    }
}
