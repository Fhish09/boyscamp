using UnityEngine;

namespace Boyscamp.Skins
{
    public enum SkinRarity
    {
        Common,
        Rare,
        Epic,
        Legendary,
        Mythic
    }

    public enum SkinType
    {
        Character,
        Weapon,
        Melee,
        Charm,
        Vehicle
    }

    [CreateAssetMenu(fileName = "NewSkin", menuName = "Boyscamp/Skin Data")]
    public class SkinData : ScriptableObject
    {
        public string skinName;
        public string skinId;
        public SkinRarity rarity;
        public SkinType type;

        [TextArea]
        public string description;

        public Sprite icon;
        public GameObject skinPrefab;          // 3D model or outfit
        public Material[] materials;           // Optional material overrides

        [Header("Visual Effects")]
        public GameObject idleVFX;
        public GameObject trailVFX;
        public GameObject killEffect;

        [Header("Unlock")]
        public bool isDefault;
        public int unlockLevel;
        public int price;
    }
}
