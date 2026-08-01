using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Boyscamp.UI
{
    public class BattlePassBanner : MonoBehaviour
    {
        [Header("Shimmer")]
        public Image shimmerImage;
        public float shimmerSpeed = 1.2f;
        public float shimmerInterval = 5f;

        private Button button;

        void Start()
        {
            button = GetComponent<Button>();
            if (button != null)
                button.onClick.AddListener(OnBannerClicked);

            if (shimmerImage != null)
                StartCoroutine(ShimmerLoop());
        }

        IEnumerator ShimmerLoop()
        {
            while (true)
            {
                yield return new WaitForSeconds(shimmerInterval);

                if (shimmerImage != null)
                {
                    float t = 0f;
                    while (t < 1f)
                    {
                        t += Time.deltaTime * shimmerSpeed;
                        float x = Mathf.Lerp(-1.2f, 1.2f, t);
                        shimmerImage.rectTransform.anchoredPosition = new Vector2(x * 400f, 0);
                        yield return null;
                    }
                }
            }
        }

        void OnBannerClicked()
        {
            Debug.Log("Battle Pass Banner clicked");
            // Open Battle Pass screen later
        }
    }
}
