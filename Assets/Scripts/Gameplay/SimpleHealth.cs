using UnityEngine;
using UnityEngine.Events;

namespace Boyscamp.Gameplay
{
    public class SimpleHealth : MonoBehaviour
    {
        public float maxHealth = 100f;
        public float currentHealth;

        public UnityEvent onDeath;

        void Start()
        {
            currentHealth = maxHealth;
        }

        public void TakeDamage(float amount)
        {
            currentHealth -= amount;
            currentHealth = Mathf.Max(0f, currentHealth);

            Debug.Log(gameObject.name + " health: " + currentHealth);

            if (currentHealth <= 0f)
            {
                Die();
            }
        }

        void Die()
        {
            onDeath?.Invoke();
            Debug.Log(gameObject.name + " died");

            // Simple destroy for now
            Destroy(gameObject, 0.1f);
        }

        public float GetHealthPercent()
        {
            return currentHealth / maxHealth;
        }
    }
}
