using UnityEngine;

namespace Boyscamp.UI
{
    public class BackgroundParallax : MonoBehaviour
    {
        public Transform background;
        public float parallaxStrength = 15f;
        public float smoothSpeed = 5f;

        private Vector3 initialPosition;
        private Vector3 targetPosition;

        void Start()
        {
            if (background != null)
                initialPosition = background.localPosition;
        }

        void Update()
        {
            if (background == null) return;

            // Simple device tilt / mouse parallax simulation
            float x = Input.acceleration.x;
            float y = Input.acceleration.y;

            // Fallback for editor testing with mouse
            if (Application.isEditor)
            {
                x = (Input.mousePosition.x / Screen.width - 0.5f) * 2f;
                y = (Input.mousePosition.y / Screen.height - 0.5f) * 2f;
            }

            targetPosition = initialPosition + new Vector3(x * parallaxStrength, y * parallaxStrength, 0f);
            background.localPosition = Vector3.Lerp(background.localPosition, targetPosition, Time.deltaTime * smoothSpeed);
        }
    }
}
