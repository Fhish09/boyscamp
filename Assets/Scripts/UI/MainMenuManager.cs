using UnityEngine;
using UnityEngine.SceneManagement;

namespace Boyscamp.UI
{
    public class MainMenuManager : MonoBehaviour
    {
        public static MainMenuManager Instance;

        [Header("Systems")]
        public MainMenuUI mainMenuUI;
        public ModeTabSystem modeTabs;
        public PlayerDataDisplay playerData;
        public MainMenuSound sound;
        public MainMenuEntrance entrance;

        void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
        }

        public void OnDeploy()
        {
            if (sound != null)
                sound.PlayDeploy();

            int mode = modeTabs != null ? modeTabs.GetSelectedIndex() : 0;

            switch (mode)
            {
                case 0: // Battle Royale
                    SceneManager.LoadScene("CCSS_Nkolmbong");
                    break;
                case 1: // Multiplayer
                    SceneManager.LoadScene("MultiplayerLobby");
                    break;
                case 2: // Ranked
                    SceneManager.LoadScene("RankedLobby");
                    break;
                default:
                    SceneManager.LoadScene("CCSS_Nkolmbong");
                    break;
            }
        }

        public void OpenLoadout()
        {
            if (sound != null) sound.PlayClick();
            Debug.Log("Open Loadout");
        }

        public void OpenStore()
        {
            if (sound != null) sound.PlayCurrency();
            Debug.Log("Open Store");
        }

        public void OpenSocial()
        {
            if (sound != null) sound.PlayClick();
            Debug.Log("Open Social / Clan");
        }

        public void OpenEvents()
        {
            if (sound != null) sound.PlayClick();
            Debug.Log("Open Events");
        }

        public void OpenSettings()
        {
            if (sound != null) sound.PlayClick();
            Debug.Log("Open Settings");
        }

        public void OpenBattlePass()
        {
            if (sound != null) sound.PlayBanner();
            Debug.Log("Open Battle Pass");
        }

        public void OpenProfile()
        {
            if (sound != null) sound.PlayClick();
            Debug.Log("Open Profile");
        }
    }
}
