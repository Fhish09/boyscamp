using UnityEngine;

namespace Boyscamp.UI
{
    public class MainMenuFlow : MonoBehaviour
    {
        public MatchmakingPanel matchmakingPanel;
        public ModeTabSystem modeTabs;

        public void OnDeployPressed()
        {
            string mode = "BattleRoyale";

            if (modeTabs != null)
            {
                int index = modeTabs.GetSelectedIndex();
                if (index == 1) mode = "Multiplayer";
                else if (index == 2) mode = "Ranked";
            }

            if (matchmakingPanel != null)
                matchmakingPanel.StartMatchmaking(mode);
            else
                Debug.LogWarning("MatchmakingPanel not assigned");
        }
    }
}
