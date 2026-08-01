using UnityEngine;
using UnityEngine.UI;

namespace Boyscamp.UI
{
    public class QuickSettingsPanel : MonoBehaviour
    {
        public GameObject panelRoot;
        public Slider masterVolume;
        public Slider musicVolume;
        public Slider sfxVolume;
        public Toggle vibrationToggle;
        public Button closeButton;

        void Start()
        {
            if (panelRoot != null)
                panelRoot.SetActive(false);

            if (closeButton != null)
                closeButton.onClick.AddListener(Close);

            // Load saved values if available
            if (masterVolume != null)
                masterVolume.value = PlayerPrefs.GetFloat("MasterVolume", 1f);

            if (musicVolume != null)
                musicVolume.value = PlayerPrefs.GetFloat("MusicVolume", 0.8f);

            if (sfxVolume != null)
                sfxVolume.value = PlayerPrefs.GetFloat("SFXVolume", 1f);

            if (vibrationToggle != null)
                vibrationToggle.isOn = PlayerPrefs.GetInt("Vibration", 1) == 1;
        }

        public void Open()
        {
            if (panelRoot != null)
                panelRoot.SetActive(true);
        }

        public void Close()
        {
            // Save values
            if (masterVolume != null)
                PlayerPrefs.SetFloat("MasterVolume", masterVolume.value);

            if (musicVolume != null)
                PlayerPrefs.SetFloat("MusicVolume", musicVolume.value);

            if (sfxVolume != null)
                PlayerPrefs.SetFloat("SFXVolume", sfxVolume.value);

            if (vibrationToggle != null)
                PlayerPrefs.SetInt("Vibration", vibrationToggle.isOn ? 1 : 0);

            PlayerPrefs.Save();

            if (panelRoot != null)
                panelRoot.SetActive(false);
        }
    }
}
