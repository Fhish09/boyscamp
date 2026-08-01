using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Boyscamp.UI
{
    public class OperatorBackgroundController : MonoBehaviour
    {
        [Header("Background Layers")]
        public Image mainBackground;
        public Image characterLayer;
        public Image weaponLayer;
        public Image vignette;

        [Header("Camera Drift")]
        public float driftAmount = 12f;
        public float driftSpeed = 0.15f;

        [Header("Character Settings")]
        public string operatorName = "Fhish";
        public string operatorTitle = "Shadow Step";

        private Vector3 startPos;

        void Start()
        {
            if (characterLayer != null)
                startPos = characterLayer.rectTransform.localPosition;

            StartCoroutine(SlowCameraDrift());
        }

        IEnumerator SlowCameraDrift()
        {
            while (true)
            {
                float t = 0f;
                Vector3 target = startPos + new Vector3(
                    Random.Range(-driftAmount, driftAmount),
                    Random.Range(-driftAmount * 0.5f, driftAmount * 0.5f),
                    0f
                );

                while (t < 1f)
                {
                    t += Time.deltaTime * driftSpeed;
                    if (characterLayer != null)
                        characterLayer.rectTransform.localPosition = Vector3.Lerp(startPos, target, Mathf.SmoothStep(0f, 1f, t));
                    yield return null;
                }

                startPos = target;
                yield return new WaitForSeconds(1.5f);
            }
        }

        public void SetOperatorVisual(Sprite characterSprite, Sprite weaponSprite = null)
        {
            if (characterLayer != null && characterSprite != null)
                characterLayer.sprite = characterSprite;

            if (weaponLayer != null && weaponSprite != null)
                weaponLayer.sprite = weaponSprite;
        }
    }
}
