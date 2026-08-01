using UnityEngine;
using UnityEngine.UI;

namespace Boyscamp.UI
{
    public class LoadoutPreview : MonoBehaviour
    {
        [Header("UI References")]
        public Text primaryWeaponName;
        public Text secondaryWeaponName;
        public Text lethalName;
        public Text tacticalName;
        public Image primaryIcon;
        public Image secondaryIcon;

        [Header("Default Loadout (can be changed later)")]
        public string defaultPrimary = "Mystic VMP";
        public string defaultSecondary = ".50 GS";
        public string defaultLethal = "Frag Grenade";
        public string defaultTactical = "Smoke";

        void Start()
        {
            RefreshLoadout();
        }

        public void RefreshLoadout()
        {
            if (primaryWeaponName != null)
                primaryWeaponName.text = defaultPrimary;

            if (secondaryWeaponName != null)
                secondaryWeaponName.text = defaultSecondary;

            if (lethalName != null)
                lethalName.text = defaultLethal;

            if (tacticalName != null)
                tacticalName.text = defaultTactical;
        }

        public void SetLoadout(string primary, string secondary, string lethal, string tactical)
        {
            defaultPrimary = primary;
            defaultSecondary = secondary;
            defaultLethal = lethal;
            defaultTactical = tactical;
            RefreshLoadout();
        }
    }
}
