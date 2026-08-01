using UnityEngine;

namespace Boyscamp.Gameplay
{
    public class SimplePlayerController : MonoBehaviour
    {
        [Header("Movement")]
        public float moveSpeed = 6f;
        public float sprintSpeed = 9f;
        public float rotationSpeed = 120f;

        [Header("Jump")]
        public float jumpForce = 7f;
        public Transform groundCheck;
        public float groundDistance = 0.3f;
        public LayerMask groundMask;

        private CharacterController controller;
        private Vector3 velocity;
        private bool isGrounded;
        private float gravity = -18f;

        void Start()
        {
            controller = GetComponent<CharacterController>();
            if (controller == null)
                controller = gameObject.AddComponent<CharacterController>();
        }

        void Update()
        {
            // Ground check
            isGrounded = Physics.CheckSphere(groundCheck != null ? groundCheck.position : transform.position, groundDistance, groundMask);

            if (isGrounded && velocity.y < 0)
                velocity.y = -2f;

            // Movement input (works with both keyboard and simple mobile)
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            // Simple touch fallback for mobile testing
            if (Input.touchCount > 0)
            {
                Touch t = Input.GetTouch(0);
                if (t.position.x < Screen.width * 0.4f)
                {
                    // Left side of screen = move forward roughly
                    z = 1f;
                }
            }

            bool sprinting = Input.GetKey(KeyCode.LeftShift);
            float speed = sprinting ? sprintSpeed : moveSpeed;

            Vector3 move = transform.right * x + transform.forward * z;
            controller.Move(move * speed * Time.deltaTime);

            // Jump
            if (Input.GetButtonDown("Jump") && isGrounded)
                velocity.y = jumpForce;

            // Gravity
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }
    }
}
