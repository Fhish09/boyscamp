using UnityEngine;
using UnityEngine.SceneManagement;

namespace Boyscamp.UI
{
    public class MainMenu : MonoBehaviour
    {
        public void PlayBattleRoyale()
        {
            // Load BR scene
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
