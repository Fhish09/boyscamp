using UnityEngine;
using UnityEngine.UI;

namespace Boyscamp.UI
{
    public class VignetteController : MonoBehaviour
    {
        public Image vignetteImage;
        public float intensity = 0.65f;

        void Start()
        {
            if (vignetteImage != null)
            {
                Color c = vignetteImage.color;
                c.a = intensity;
                vignetteImage.color = c;
            }
        }

        public void SetIntensity(float value)
        {
            intensity = Mathf.Clamp01(value);
            if (vignetteImage != null)
            {
                Color c = vignetteImage.color;
                c.a = intensity;
                vignetteImage.color = c;
            }
        }
    }
}
