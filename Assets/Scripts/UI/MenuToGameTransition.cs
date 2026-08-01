using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Boyscamp.UI
{
    public class MenuToGameTransition : MonoBehaviour
    {
        public static MenuToGameTransition Instance;

        [Header("Transition")]
        public Image fadeImage;
        public float fadeDuration = 0.45f;

        void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
        }

        public void FadeOutAndLoad(string sceneName)
        {
            StartCoroutine(FadeOutRoutine(sceneName));
        }

        IEnumerator FadeOutRoutine(string sceneName)
        {
            if (fadeImage != null)
            {
                fadeImage.gameObject.SetActive(true);
                Color c = fadeImage.color;
                c.a = 0f;
                fadeImage.color = c;

                float t = 0f;
                while (t < 1f)
                {
                    t += Time.deltaTime / fadeDuration;
                    c.a = Mathf.SmoothStep(0f, 1f, t);
                    fadeImage.color = c;
                    yield return null;
                }
            }

            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }
}
