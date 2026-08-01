using UnityEngine;
using UnityEngine.UI;

namespace Boyscamp.UI
{
    public class XPBar : MonoBehaviour
    {
        public Image fillImage;
        public Text levelText;
        public Text xpText;

        public void SetXP(int currentXP, int requiredXP, int level)
        {
            if (fillImage != null)
            {
                float progress = requiredXP > 0 ? (float)currentXP / requiredXP : 0f;
                fillImage.fillAmount = Mathf.Clamp01(progress);
            }

            if (levelText != null)
                levelText.text = "Lv. " + level;

            if (xpText != null)
                xpText.text = currentXP + " / " + requiredXP;
        }
    }
}
