using UnityEngine;
using UnityEngine.UI;

namespace Boyscamp.UI
{
    public class SeasonProgress : MonoBehaviour
    {
        [Header("UI")]
        public Text seasonNameText;
        public Text tierText;
        public Image progressFill;
        public Text progressLabel;

        [Header("Data")]
        public string seasonName = "Season 1: Shadow Rising";
        public int currentTier = 27;
        public int maxTier = 100;
        public int currentXP = 3400;
        public int requiredXP = 5000;

        void Start()
        {
            Refresh();
        }

        public void Refresh()
        {
            if (seasonNameText != null)
                seasonNameText.text = seasonName;

            if (tierText != null)
                tierText.text = "Tier " + currentTier;

            if (progressFill != null)
                progressFill.fillAmount = (float)currentXP / requiredXP;

            if (progressLabel != null)
                progressLabel.text = currentXP + " / " + requiredXP + " XP";
        }

        public void AddXP(int amount)
        {
            currentXP += amount;
            if (currentXP >= requiredXP)
            {
                currentXP -= requiredXP;
                currentTier = Mathf.Min(currentTier + 1, maxTier);
            }
            Refresh();
        }
    }
}
