using UnityEngine;
using UnityEngine.UI;
using Boyscamp.Weapons;

namespace Boyscamp.UI
{
    public class SimpleHUD : MonoBehaviour
    {
        public Text ammoText;
        public Text healthText;
        public Image healthBar;

        public SimpleWeapon weapon;
        public Boyscamp.Gameplay.SimpleHealth playerHealth;

        void Update()
        {
            if (weapon != null && ammoText != null)
            {
                ammoText.text = weapon.GetCurrentAmmo() + " / " + weapon.GetMaxAmmo();
            }

            if (playerHealth != null)
            {
                if (healthText != null)
                    healthText.text = Mathf.CeilToInt(playerHealth.currentHealth).ToString();

                if (healthBar != null)
                    healthBar.fillAmount = playerHealth.GetHealthPercent();
            }
        }
    }
}
