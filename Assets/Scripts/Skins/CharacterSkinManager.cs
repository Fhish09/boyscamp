using UnityEngine;
using System.Collections.Generic;

namespace Boyscamp.Skins
{
    public class CharacterSkinManager : MonoBehaviour
    {
        public static CharacterSkinManager Instance;

        [Header("Equipped Skins")]
        public SkinData currentCharacterSkin;
        public SkinData currentWeaponSkin;

        [Header("Available Skins")]
        public List<SkinData> ownedSkins = new List<SkinData>();

        [Header("Default Skins")]
        public SkinData defaultFhishSkin;
        public SkinData schoolUniformSkin;

        void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
        }

        void Start()
        {
            // Equip default if nothing is equipped
            if (currentCharacterSkin == null && defaultFhishSkin != null)
                EquipCharacterSkin(defaultFhishSkin);
        }

        public void EquipCharacterSkin(SkinData skin)
        {
            if (skin == null) return;

            currentCharacterSkin = skin;
            Debug.Log("Equipped character skin: " + skin.skinName);

            // Here you would swap the actual 3D model / materials
            ApplySkinVisuals(skin);
        }

        public void EquipWeaponSkin(SkinData skin)
        {
            if (skin == null) return;

            currentWeaponSkin = skin;
            Debug.Log("Equipped weapon skin: " + skin.skinName);
            ApplySkinVisuals(skin);
        }

        void ApplySkinVisuals(SkinData skin)
        {
            // Placeholder for model swapping
            // In the future this will instantiate skin.skinPrefab or change materials
            if (skin.idleVFX != null)
            {
                // Spawn idle VFX on the player later
            }
        }

        public bool OwnsSkin(SkinData skin)
        {
            return ownedSkins.Contains(skin) || (skin != null && skin.isDefault);
        }

        public void UnlockSkin(SkinData skin)
        {
            if (!ownedSkins.Contains(skin))
            {
                ownedSkins.Add(skin);
                Debug.Log("Unlocked skin: " + skin.skinName);
            }
        }
    }
}
