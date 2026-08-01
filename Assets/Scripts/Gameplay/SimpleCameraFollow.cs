using UnityEngine;

namespace Boyscamp.Gameplay
{
    public class SimpleCameraFollow : MonoBehaviour
    {
        public Transform target;
        public Vector3 offset = new Vector3(0f, 4.5f, -6.5f);
        public float followSpeed = 8f;
        public float mouseSensitivity = 2.5f;

        private float yaw;
        private float pitch = 15f;

        void LateUpdate()
        {
            if (target == null) return;

            // Mouse look
            yaw += Input.GetAxis("Mouse X") * mouseSensitivity;
            pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
            pitch = Mathf.Clamp(pitch, -20f, 60f);

            Quaternion rotation = Quaternion.Euler(pitch, yaw, 0f);
            Vector3 desiredPosition = target.position + rotation * offset;

            transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);
            transform.LookAt(target.position + Vector3.up * 1.6f);
        }
    }
}
