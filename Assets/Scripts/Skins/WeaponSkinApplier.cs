using UnityEngine;

namespace Boyscamp.Skins
{
    public class WeaponSkinApplier : MonoBehaviour
    {
        public Renderer[] weaponRenderers;
        public SkinData currentSkin;

        public void ApplySkin(SkinData skin)
        {
            if (skin == null) return;

            currentSkin = skin;

            if (skin.materials != null && skin.materials.Length > 0 && weaponRenderers != null)
            {
                foreach (var rend in weaponRenderers)
                {
                    if (rend != null)
                        rend.materials = skin.materials;
                }
            }

            Debug.Log("Weapon skin applied: " + skin.skinName);
        }
    }
}
