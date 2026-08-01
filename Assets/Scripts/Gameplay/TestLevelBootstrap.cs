using UnityEngine;

namespace Boyscamp.Gameplay
{
    public class TestLevelBootstrap : MonoBehaviour
    {
        void Start()
        {
            // Create a simple ground if none exists
            if (GameObject.Find("Ground") == null)
            {
                GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
                ground.name = "Ground";
                ground.transform.position = Vector3.zero;
                ground.transform.localScale = new Vector3(8f, 1f, 8f);

                // Give it a dark color
                Renderer r = ground.GetComponent<Renderer>();
                if (r != null)
                {
                    r.material.color = new Color(0.15f, 0.18f, 0.15f);
                }
            }

            // Create player if none exists
            if (GameObject.Find("Player") == null)
            {
                GameObject player = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                player.name = "Player";
                player.transform.position = new Vector3(0f, 1.5f, 0f);

                // Remove the default collider because CharacterController will handle it
                Collider col = player.GetComponent<Collider>();
                if (col != null) Destroy(col);

                player.AddComponent<CharacterController>();
                player.AddComponent<SimplePlayerController>();

                // Ground check object
                GameObject groundCheck = new GameObject("GroundCheck");
                groundCheck.transform.SetParent(player.transform);
                groundCheck.transform.localPosition = new Vector3(0f, -0.9f, 0f);

                SimplePlayerController spc = player.GetComponent<SimplePlayerController>();
                spc.groundCheck = groundCheck.transform;
                spc.groundMask = LayerMask.GetMask("Default");
            }

            // Setup camera
            Camera cam = Camera.main;
            if (cam != null)
            {
                SimpleCameraFollow follow = cam.gameObject.GetComponent<SimpleCameraFollow>();
                if (follow == null)
                    follow = cam.gameObject.AddComponent<SimpleCameraFollow>();

                GameObject playerObj = GameObject.Find("Player");
                if (playerObj != null)
                    follow.target = playerObj.transform;
            }

            Debug.Log("Test Level Ready - Use WASD to move, Mouse to look, Space to jump");
        }
    }
}
