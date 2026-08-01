using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Boyscamp.UI
{
    public class NotificationToast : MonoBehaviour
    {
        public static NotificationToast Instance;

        public GameObject toastRoot;
        public Text toastText;
        public CanvasGroup canvasGroup;
        public float displayTime = 2.2f;

        void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);

            if (toastRoot != null)
                toastRoot.SetActive(false);
        }

        public void Show(string message)
        {
            StopAllCoroutines();
            StartCoroutine(ShowRoutine(message));
        }

        IEnumerator ShowRoutine(string message)
        {
            if (toastRoot != null)
                toastRoot.SetActive(true);

            if (toastText != null)
                toastText.text = message;

            if (canvasGroup != null)
            {
                canvasGroup.alpha = 0f;
                float t = 0f;
                while (t < 1f)
                {
                    t += Time.deltaTime * 4f;
                    canvasGroup.alpha = t;
                    yield return null;
                }
            }

            yield return new WaitForSeconds(displayTime);

            if (canvasGroup != null)
            {
                float t = 1f;
                while (t > 0f)
                {
                    t -= Time.deltaTime * 3f;
                    canvasGroup.alpha = t;
                    yield return null;
                }
            }

            if (toastRoot != null)
                toastRoot.SetActive(false);
        }
    }
}
