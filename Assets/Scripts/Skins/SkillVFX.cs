using UnityEngine;

namespace Boyscamp.Skins
{
    public class SkillVFX : MonoBehaviour
    {
        [Header("Shadow Step VFX")]
        public GameObject dashTrailPrefab;
        public GameObject dashBurstPrefab;
        public float trailDuration = 0.6f;

        [Header("Hunter Instinct VFX")]
        public GameObject speedAuraPrefab;

        public void PlayShadowStepVFX(Vector3 position, Vector3 direction)
        {
            if (dashBurstPrefab != null)
            {
                GameObject burst = Instantiate(dashBurstPrefab, position, Quaternion.LookRotation(direction));
                Destroy(burst, 2f);
            }

            if (dashTrailPrefab != null)
            {
                GameObject trail = Instantiate(dashTrailPrefab, position, Quaternion.LookRotation(direction));
                Destroy(trail, trailDuration);
            }

            Debug.Log("Shadow Step VFX played");
        }

        public void PlayHunterInstinctVFX(Transform target)
        {
            if (speedAuraPrefab != null && target != null)
            {
                GameObject aura = Instantiate(speedAuraPrefab, target);
                aura.transform.localPosition = Vector3.zero;
                Destroy(aura, 5f);
            }

            Debug.Log("Hunter's Instinct VFX played");
        }
    }
}
