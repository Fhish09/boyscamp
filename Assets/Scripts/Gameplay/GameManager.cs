using UnityEngine;
using UnityEngine.SceneManagement;

namespace Boyscamp.Gameplay
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        public enum GameMode { BattleRoyale, Multiplayer, CampusClash }
        public GameMode currentMode = GameMode.BattleRoyale;

        public int playersAlive = 100;
        public bool matchStarted = false;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void StartMatch()
        {
            matchStarted = true;
            Debug.Log("Match started - Mode: " + currentMode);
        }

        public void PlayerEliminated()
        {
            playersAlive--;
            if (playersAlive <= 1)
            {
                EndMatch();
            }
        }

        void EndMatch()
        {
            Debug.Log("Match Ended");
            // Show victory screen
        }
    }
}
