using UnityEngine;
using UnityEngine.SceneManagement;

namespace Boyscamp.UI
{
    // Legacy script kept for compatibility
    // New main menu logic is in MainMenuUI.cs
    public class MainMenu : MonoBehaviour
    {
        public void PlayBattleRoyale()
        {
            SceneManager.LoadScene("CCSS_Nkolmbong");
        }

        public void PlayCampusClash()
        {
            SceneManager.LoadScene("CampusClash");
        }

        public void OpenSettings()
        {
            Debug.Log("Open Settings");
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}
