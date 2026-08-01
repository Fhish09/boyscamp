using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

namespace Boyscamp.UI
{
    public class MainMenuUI : MonoBehaviour
    {
        [Header("Top Bar")]
        public Button avatarButton;
        public Text levelText;
        public Image xpBarFill;
        public Button softCurrencyButton;
        public Button hardCurrencyButton;

        [Header("Center")]
        public Button battlePassBanner;
        public Button brTab;
        public Button multiplayerTab;
        public Button rankedTab;

        [Header("Primary CTA")]
        public Button deployButton;
        public Image deployGlow;

        [Header("Bottom Nav")]
        public Button loadoutButton;
        public Button storeButton;
        public Button socialButton;
        public Button eventsButton;
        public Button settingsButton;

        private string selectedMode = "BattleRoyale";

        void Start()
        {
            SetupButtons();
            StartCoroutine(EntranceAnimation());
            StartCoroutine(DeployGlowPulse());
        }

        void SetupButtons()
        {
            if (deployButton != null)
                deployButton.onClick.AddListener(OnDeployPressed);

            if (brTab != null)
                brTab.onClick.AddListener(() => SelectMode("BattleRoyale"));

            if (multiplayerTab != null)
                multiplayerTab.onClick.AddListener(() => SelectMode("Multiplayer"));

            if (rankedTab != null)
                rankedTab.onClick.AddListener(() => SelectMode("Ranked"));

            if (settingsButton != null)
                settingsButton.onClick.AddListener(OpenSettings);

            if (loadoutButton != null)
                loadoutButton.onClick.AddListener(OpenLoadout);

            if (storeButton != null)
                storeButton.onClick.AddListener(OpenStore);

            if (socialButton != null)
                socialButton.onClick.AddListener(OpenSocial);

            if (eventsButton != null)
                eventsButton.onClick.AddListener(OpenEvents);

            if (battlePassBanner != null)
                battlePassBanner.onClick.AddListener(OpenBattlePass);

            if (avatarButton != null)
                avatarButton.onClick.AddListener(OpenProfile);
        }

        void SelectMode(string mode)
        {
            selectedMode = mode;
            Debug.Log("Selected mode: " + mode);
            // Visual feedback for selected tab can be added here
        }

        void OnDeployPressed()
        {
            Debug.Log("DEPLOY pressed - Mode: " + selectedMode);
            StartCoroutine(DeployTransition());
        }

        IEnumerator DeployTransition()
        {
            // Simple scale feedback
            if (deployButton != null)
            {
                deployButton.transform.localScale = Vector3.one * 0.94f;
                yield return new WaitForSeconds(0.1f);
                deployButton.transform.localScale = Vector3.one;
            }

            // Load scene based on mode
            if (selectedMode == "BattleRoyale")
                SceneManager.LoadScene("CCSS_Nkolmbong");
            else if (selectedMode == "Multiplayer")
                SceneManager.LoadScene("MultiplayerLobby");
            else
                SceneManager.LoadScene("RankedLobby");
        }

        IEnumerator EntranceAnimation()
        {
            // Staggered entrance
            yield return new WaitForSeconds(0.1f);
            // TopBar can fade in here
            yield return new WaitForSeconds(0.15f);
            // Banner
            yield return new WaitForSeconds(0.15f);
            // Deploy button last
        }

        IEnumerator DeployGlowPulse()
        {
            while (true)
            {
                if (deployGlow != null)
                {
                    float t = 0f;
                    while (t < 2f)
                    {
                        t += Time.deltaTime;
                        float alpha = 0.4f + Mathf.Sin(t * Mathf.PI) * 0.3f;
                        Color c = deployGlow.color;
                        c.a = alpha;
                        deployGlow.color = c;
                        yield return null;
                    }
                }
                else
                {
                    yield return new WaitForSeconds(2f);
                }
            }
        }

        void OpenSettings() { Debug.Log("Open Settings"); }
        void OpenLoadout() { Debug.Log("Open Loadout"); }
        void OpenStore() { Debug.Log("Open Store"); }
        void OpenSocial() { Debug.Log("Open Social"); }
        void OpenEvents() { Debug.Log("Open Events"); }
        void OpenBattlePass() { Debug.Log("Open Battle Pass"); }
        void OpenProfile() { Debug.Log("Open Profile"); }
    }
}
