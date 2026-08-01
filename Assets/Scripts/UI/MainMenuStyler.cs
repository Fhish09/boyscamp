using UnityEngine;
using UnityEngine.UI;

namespace Boyscamp.UI
{
    public class MainMenuStyler : MonoBehaviour
    {
        [Header("Color Palette")]
        public Color primaryAccent = new Color(1f, 0.35f, 0.1f); // Orange-Red
        public Color secondaryAccent = new Color(0.15f, 0.7f, 1f); // Cyan
        public Color darkBackground = new Color(0.05f, 0.05f, 0.08f);
        public Color textPrimary = Color.white;
        public Color textMuted = new Color(0.7f, 0.7f, 0.75f);

        [Header("References")]
        public Image deployButtonImage;
        public Text deployLabel;
        public Image[] modeTabImages;
        public Text[] modeTabLabels;

        void Start()
        {
            ApplyStyles();
        }

        public void ApplyStyles()
        {
            if (deployButtonImage != null)
                deployButtonImage.color = primaryAccent;

            if (deployLabel != null)
            {
                deployLabel.color = Color.white;
                deployLabel.fontStyle = FontStyle.Bold;
            }

            // Mode tabs styling can be expanded here
        }

        public void SetSelectedMode(int index)
        {
            if (modeTabImages == null) return;

            for (int i = 0; i < modeTabImages.Length; i++)
            {
                if (modeTabImages[i] != null)
                {
                    modeTabImages[i].color = (i == index) ? primaryAccent : new Color(0.2f, 0.2f, 0.25f);
                }
            }
        }
    }
}
