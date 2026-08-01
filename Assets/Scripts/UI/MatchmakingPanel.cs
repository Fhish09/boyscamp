using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Boyscamp.UI
{
    public class MatchmakingPanel : MonoBehaviour
    {
        [Header("UI")]
        public GameObject panelRoot;
        public Text statusText;
        public Text playerCountText;
        public Image progressBar;
        public Button cancelButton;

        [Header("Settings")]
        public float simulatedSearchTime = 4.5f;

        private bool isSearching = false;

        void Start()
        {
            if (panelRoot != null)
                panelRoot.SetActive(false);

            if (cancelButton != null)
                cancelButton.onClick.AddListener(CancelMatchmaking);
        }

        public void StartMatchmaking(string modeName)
        {
            if (isSearching) return;

            isSearching = true;
            if (panelRoot != null)
                panelRoot.SetActive(true);

            if (statusText != null)
                statusText.text = "Searching for players...";

            StartCoroutine(SimulateSearch(modeName));
        }

        IEnumerator SimulateSearch(string modeName)
        {
            float timer = 0f;
            int playersFound = 1;

            while (timer < simulatedSearchTime)
            {
                timer += Time.deltaTime;

                if (progressBar != null)
                    progressBar.fillAmount = timer / simulatedSearchTime;

                // Fake player count rising
                playersFound = Mathf.Min(4, 1 + (int)(timer * 1.2f));
                if (playerCountText != null)
                    playerCountText.text = playersFound + " / 4 Squad";

                if (statusText != null)
                {
                    if (timer < simulatedSearchTime * 0.6f)
                        statusText.text = "Searching for players...";
                    else
                        statusText.text = "Almost ready...";
                }

                yield return null;
            }

            if (statusText != null)
                statusText.text = "Match Found!";

            yield return new WaitForSeconds(0.8f);

            // Load the map
            if (modeName == "BattleRoyale")
                UnityEngine.SceneManagement.SceneManager.LoadScene("CCSS_Nkolmbong");
            else if (modeName == "Multiplayer")
                UnityEngine.SceneManagement.SceneManager.LoadScene("MultiplayerLobby");
            else
                UnityEngine.SceneManagement.SceneManager.LoadScene("RankedLobby");
        }

        public void CancelMatchmaking()
        {
            isSearching = false;
            StopAllCoroutines();

            if (panelRoot != null)
                panelRoot.SetActive(false);

            Debug.Log("Matchmaking cancelled");
        }
    }
}
