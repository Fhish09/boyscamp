using UnityEngine;

namespace Boyscamp.Player.Skills
{
    public class ShadowStepSkill : CharacterSkill
    {
        public float dashDistance = 8f;
        public float aimBreakDuration = 2f;

        void Awake()
        {
            skillName = "Shadow Step";
            cooldown = 25f;
        }

        protected override void OnActivate()
        {
            // Dash forward
            CharacterController cc = GetComponent<CharacterController>();
            if (cc != null)
            {
                Vector3 dash = transform.forward * dashDistance;
                cc.Move(dash);
            }
            else
            {
                transform.position += transform.forward * dashDistance;
            }

            Debug.Log("Shadow Step activated - Dashed forward");

            // TODO: Add temporary aim-assist break effect on enemies later
        }
    }
}
