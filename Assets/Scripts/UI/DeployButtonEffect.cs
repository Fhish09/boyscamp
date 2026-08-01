using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Boyscamp.UI
{
    public class DeployButtonEffect : MonoBehaviour
    {
        [Header("Glow Settings")]
        public Image glowImage;
        public float pulseSpeed = 1.5f;
        public float minAlpha = 0.35f;
        public float maxAlpha = 0.75f;

        [Header("Shockwave")]
        public GameObject shockwavePrefab;
        public Transform shockwaveParent;

        private Button button;

        void Start()
        {
            button = GetComponent<Button>();
            if (button != null)
                button.onClick.AddListener(PlayShockwave);

            if (glowImage != null)
                StartCoroutine(PulseGlow());
        }

        IEnumerator PulseGlow()
        {
            while (true)
            {
                float t = 0f;
                while (t < 1f)
                {
                    t += Time.deltaTime * pulseSpeed;
                    float alpha = Mathf.Lerp(minAlpha, maxAlpha, Mathf.Sin(t * Mathf.PI));
                    Color c = glowImage.color;
                    c.a = alpha;
                    glowImage.color = c;
                    yield return null;
                }
            }
        }

        void PlayShockwave()
        {
            if (shockwavePrefab != null && shockwaveParent != null)
            {
                GameObject wave = Instantiate(shockwavePrefab, shockwaveParent);
                Destroy(wave, 0.5f);
            }
        }
    }
}
