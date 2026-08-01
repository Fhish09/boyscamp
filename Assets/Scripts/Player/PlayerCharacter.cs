using UnityEngine;

namespace Boyscamp.Player
{
    public class PlayerCharacter : MonoBehaviour
    {
        public CharacterData data;
        public CharacterSkill activeSkill;

        [Header("Runtime")]
        public string displayName;
        public string title;

        void Start()
        {
            if (data != null)
            {
                displayName = data.characterName;
                title = data.title;
            }

            // Auto add Fhish skills if this is Fhish
            if (data != null && data.characterName == "Fhish")
            {
                if (GetComponent<Skills.ShadowStepSkill>() == null)
                    gameObject.AddComponent<Skills.ShadowStepSkill>();

                if (GetComponent<Skills.HuntersInstinctPassive>() == null)
                    gameObject.AddComponent<Skills.HuntersInstinctPassive>();

                activeSkill = GetComponent<Skills.ShadowStepSkill>();
            }
        }

        void Update()
        {
            // Activate skill with Q key for testing
            if (Input.GetKeyDown(KeyCode.Q) && activeSkill != null)
            {
                activeSkill.Activate();
            }
        }
    }
}
