using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

namespace Boyscamp.UI
{
    public class MainMenuButtonFeedback : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
    {
        [Header("Feedback Settings")]
        public float pressScale = 0.94f;
        public float hoverScale = 1.05f;
        public float animSpeed = 12f;

        private Vector3 originalScale;
        private Vector3 targetScale;
        private bool isPressed = false;

        void Awake()
        {
            originalScale = transform.localScale;
            targetScale = originalScale;
        }

        void Update()
        {
            transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * animSpeed);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            isPressed = true;
            targetScale = originalScale * pressScale;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            isPressed = false;
            targetScale = originalScale;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            if (!isPressed)
                targetScale = originalScale * hoverScale;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            if (!isPressed)
                targetScale = originalScale;
        }
    }
}
