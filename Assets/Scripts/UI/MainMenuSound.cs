using UnityEngine;

namespace Boyscamp.UI
{
    public class MainMenuSound : MonoBehaviour
    {
        [Header("UI Sounds")]
        public AudioClip clickSound;
        public AudioClip deploySound;
        public AudioClip bannerSound;
        public AudioClip currencySound;
        public AudioClip deniedSound;

        private AudioSource source;

        void Awake()
        {
            source = GetComponent<AudioSource>();
            if (source == null)
                source = gameObject.AddComponent<AudioSource>();

            source.playOnAwake = false;
        }

        public void PlayClick()
        {
            Play(clickSound, 0.7f);
        }

        public void PlayDeploy()
        {
            Play(deploySound, 1f);
        }

        public void PlayBanner()
        {
            Play(bannerSound, 0.8f);
        }

        public void PlayCurrency()
        {
            Play(currencySound, 0.6f);
        }

        public void PlayDenied()
        {
            Play(deniedSound, 0.9f);
        }

        void Play(AudioClip clip, float volume)
        {
            if (clip != null && source != null)
                source.PlayOneShot(clip, volume);
        }
    }
}
