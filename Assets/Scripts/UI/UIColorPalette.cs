using UnityEngine;

namespace Boyscamp.UI
{
    [CreateAssetMenu(fileName = "UIColorPalette", menuName = "Boyscamp/UI Color Palette")]
    public class UIColorPalette : ScriptableObject
    {
        public Color primaryAccent = new Color(1f, 0.35f, 0.1f);
        public Color secondaryAccent = new Color(0.15f, 0.7f, 1f);
        public Color backgroundDark = new Color(0.047f, 0.047f, 0.07f);
        public Color panelBackground = new Color(0.086f, 0.086f, 0.118f);
        public Color textPrimary = Color.white;
        public Color textMuted = new Color(0.67f, 0.67f, 0.725f);
        public Color success = new Color(0.2f, 0.85f, 0.4f);
        public Color danger = new Color(0.95f, 0.25f, 0.25f);
    }
}
