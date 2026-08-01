using UnityEngine;
using UnityEngine.UI;

namespace Boyscamp.UI
{
    // Helper to quickly apply solid colors to UI Images during prototyping
    public class SimpleImageFiller : MonoBehaviour
    {
        public Color color = Color.white;

        void Reset()
        {
            Image img = GetComponent<Image>();
            if (img != null)
                img.color = color;
        }

        void OnValidate()
        {
            Image img = GetComponent<Image>();
            if (img != null)
                img.color = color;
        }
    }
}
