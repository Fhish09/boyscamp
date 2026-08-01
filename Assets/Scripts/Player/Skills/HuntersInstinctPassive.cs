using UnityEngine;

namespace Boyscamp.Player.Skills
{
    public class HuntersInstinctPassive : MonoBehaviour
    {
        public float speedBoost = 0.10f;
        public float duration = 5f;

        private float boostEndTime;
        private Boyscamp.Gameplay.SimplePlayerController controller;
        private float originalSpeed;

        void Start()
        {
            controller = GetComponent<Boyscamp.Gameplay.SimplePlayerController>();
            if (controller != null)
                originalSpeed = controller.moveSpeed;
        }

        void Update()
        {
            if (Time.time < boostEndTime && controller != null)
            {
                controller.moveSpeed = originalSpeed * (1f + speedBoost);
            }
            else if (controller != null)
            {
                controller.moveSpeed = originalSpeed;
            }
        }

        public void OnEnemyKnocked()
        {
            boostEndTime = Time.time + duration;
            Debug.Log("Hunter's Instinct activated - Speed boost");
        }
    }
}
