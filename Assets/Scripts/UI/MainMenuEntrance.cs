using UnityEngine;
using System.Collections;

namespace Boyscamp.UI
{
    public class MainMenuEntrance : MonoBehaviour
    {
        [Header("Elements to animate")]
        public CanvasGroup topBar;
        public CanvasGroup battlePassBanner;
        public CanvasGroup modeTabs;
        public CanvasGroup deployButton;
        public CanvasGroup bottomNav;

        [Header("Timing")]
        public float delayBetween = 0.12f;
        public float fadeDuration = 0.35f;

        void Start()
        {
            // Hide everything first
            SetAlpha(topBar, 0);
            SetAlpha(battlePassBanner, 0);
            SetAlpha(modeTabs, 0);
            SetAlpha(deployButton, 0);
            SetAlpha(bottomNav, 0);

            StartCoroutine(PlayEntrance());
        }

        IEnumerator PlayEntrance()
        {
            yield return StartCoroutine(FadeIn(topBar));
            yield return new WaitForSeconds(delayBetween);

            yield return StartCoroutine(FadeIn(battlePassBanner));
            yield return new WaitForSeconds(delayBetween);

            yield return StartCoroutine(FadeIn(modeTabs));
            yield return new WaitForSeconds(delayBetween);

            yield return StartCoroutine(FadeIn(deployButton));
            yield return new WaitForSeconds(delayBetween);

            yield return StartCoroutine(FadeIn(bottomNav));
        }

        IEnumerator FadeIn(CanvasGroup group)
        {
            if (group == null) yield break;

            float t = 0f;
            while (t < 1f)
            {
                t += Time.deltaTime / fadeDuration;
                group.alpha = Mathf.SmoothStep(0f, 1f, t);
                yield return null;
            }
            group.alpha = 1f;
        }

        void SetAlpha(CanvasGroup group, float alpha)
        {
            if (group != null)
                group.alpha = alpha;
        }
    }
}
