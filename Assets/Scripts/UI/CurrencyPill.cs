using UnityEngine;
using UnityEngine.UI;

namespace Boyscamp.UI
{
    public class CurrencyPill : MonoBehaviour
    {
        public Text amountText;
        public Image iconImage;

        public void SetAmount(int amount)
        {
            if (amountText != null)
                amountText.text = FormatNumber(amount);
        }

        string FormatNumber(int number)
        {
            if (number >= 1000000)
                return (number / 1000000f).ToString("0.#") + "M";
            if (number >= 1000)
                return (number / 1000f).ToString("0.#") + "K";
            return number.ToString();
        }
    }
}
