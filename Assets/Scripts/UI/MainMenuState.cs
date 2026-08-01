using UnityEngine;

namespace Boyscamp.UI
{
    public enum MenuState
    {
        Main,
        Matchmaking,
        Loadout,
        Store,
        Settings,
        BattlePass,
        Clan,
        Challenges
    }

    public class MainMenuState : MonoBehaviour
    {
        public static MainMenuState Instance;

        public MenuState currentState = MenuState.Main;

        [Header("Panels")]
        public GameObject mainPanel;
        public GameObject matchmakingPanel;
        public GameObject loadoutPanel;
        public GameObject storePanel;
        public GameObject settingsPanel;
        public GameObject battlePassPanel;
        public GameObject clanPanel;
        public GameObject challengesPanel;

        void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
        }

        public void SetState(MenuState newState)
        {
            currentState = newState;
            UpdatePanels();
        }

        void UpdatePanels()
        {
            SetActive(mainPanel, currentState == MenuState.Main);
            SetActive(matchmakingPanel, currentState == MenuState.Matchmaking);
            SetActive(loadoutPanel, currentState == MenuState.Loadout);
            SetActive(storePanel, currentState == MenuState.Store);
            SetActive(settingsPanel, currentState == MenuState.Settings);
            SetActive(battlePassPanel, currentState == MenuState.BattlePass);
            SetActive(clanPanel, currentState == MenuState.Clan);
            SetActive(challengesPanel, currentState == MenuState.Challenges);
        }

        void SetActive(GameObject obj, bool active)
        {
            if (obj != null)
                obj.SetActive(active);
        }

        // Convenience methods
        public void GoToMain() => SetState(MenuState.Main);
        public void GoToMatchmaking() => SetState(MenuState.Matchmaking);
        public void GoToLoadout() => SetState(MenuState.Loadout);
        public void GoToStore() => SetState(MenuState.Store);
        public void GoToSettings() => SetState(MenuState.Settings);
        public void GoToBattlePass() => SetState(MenuState.BattlePass);
        public void GoToClan() => SetState(MenuState.Clan);
        public void GoToChallenges() => SetState(MenuState.Challenges);
    }
}
