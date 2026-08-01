using UnityEngine;
using UnityEngine.UI;

namespace Boyscamp.UI
{
    public class PlayerDataDisplay : MonoBehaviour
    {
        [Header("References")]
        public Text playerNameText;
        public Text levelText;
        public Image xpFill;
        public Text softCurrencyText;
        public Text hardCurrencyText;
        public Image avatarImage;

        // Temporary mock data (later connect to real player save)
        public string playerName = "Fhish";
        public int level = 24;
        public int currentXP = 1850;
        public int requiredXP = 2500;
        public int softCurrency = 12450;
        public int hardCurrency = 320;

        void Start()
        {
            RefreshUI();
        }

        public void RefreshUI()
        {
            if (playerNameText != null)
                playerNameText.text = playerName;

            if (levelText != null)
                levelText.text = "Lv. " + level;

            if (xpFill != null)
                xpFill.fillAmount = (float)currentXP / requiredXP;

            if (softCurrencyText != null)
                softCurrencyText.text = Format(softCurrency);

            if (hardCurrencyText != null)
                hardCurrencyText.text = Format(hardCurrency);
        }

        string Format(int value)
        {
            if (value >= 1000000) return (value / 1000000f).ToString("0.#") + "M";
            if (value >= 1000) return (value / 1000f).ToString("0.#") + "K";
            return value.ToString();
        }
    }
}
