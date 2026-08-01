using UnityEngine;

namespace Boyscamp.Player
{
    [CreateAssetMenu(fileName = "NewCharacter", menuName = "Boyscamp/Character Data")]
    public class CharacterData : ScriptableObject
    {
        public string characterName;
        public string title;
        public string description;

        [Header("Skills")]
        public string activeSkillName;
        public string activeSkillDescription;
        public float activeSkillCooldown;

        public string passiveSkillName;
        public string passiveSkillDescription;

        [Header("Stats")]
        public float maxHealth = 100f;
        public float moveSpeed = 6f;
        public float sprintMultiplier = 1.4f;

        [Header("Visual")]
        public Sprite portrait;
        public GameObject characterPrefab;
    }
}
