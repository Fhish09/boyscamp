using UnityEngine;

namespace Boyscamp.Weapons
{
    public class SimpleWeapon : MonoBehaviour
    {
        [Header("Weapon Settings")]
        public string weaponName = "Assault Rifle";
        public float damage = 25f;
        public float fireRate = 0.12f;
        public float range = 100f;
        public int maxAmmo = 30;
        public float reloadTime = 1.8f;

        [Header("References")]
        public Transform firePoint;
        public ParticleSystem muzzleFlash;
        public AudioSource audioSource;
        public AudioClip shootSound;
        public AudioClip reloadSound;

        private int currentAmmo;
        private float nextFireTime;
        private bool isReloading;

        void Start()
        {
            currentAmmo = maxAmmo;

            if (audioSource == null)
                audioSource = gameObject.AddComponent<AudioSource>();
        }

        void Update()
        {
            if (isReloading) return;

            if (Input.GetButton("Fire1") && Time.time >= nextFireTime)
            {
                Shoot();
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                StartCoroutine(Reload());
            }
        }

        void Shoot()
        {
            if (currentAmmo <= 0)
            {
                StartCoroutine(Reload());
                return;
            }

            nextFireTime = Time.time + fireRate;
            currentAmmo--;

            if (muzzleFlash != null)
                muzzleFlash.Play();

            if (shootSound != null && audioSource != null)
                audioSource.PlayOneShot(shootSound);

            RaycastHit hit;
            Vector3 origin = firePoint != null ? firePoint.position : transform.position + Vector3.up * 1.4f;
            Vector3 direction = firePoint != null ? firePoint.forward : transform.forward;

            if (Physics.Raycast(origin, direction, out hit, range))
            {
                Debug.Log("Hit: " + hit.collider.name);

                // Simple damage placeholder
                var health = hit.collider.GetComponent<Boyscamp.Gameplay.SimpleHealth>();
                if (health != null)
                {
                    health.TakeDamage(damage);
                }
            }
        }

        System.Collections.IEnumerator Reload()
        {
            if (isReloading || currentAmmo == maxAmmo) yield break;

            isReloading = true;

            if (reloadSound != null && audioSource != null)
                audioSource.PlayOneShot(reloadSound);

            Debug.Log("Reloading...");
            yield return new WaitForSeconds(reloadTime);

            currentAmmo = maxAmmo;
            isReloading = false;
            Debug.Log("Reload complete");
        }

        public int GetCurrentAmmo() => currentAmmo;
        public int GetMaxAmmo() => maxAmmo;
        public bool IsReloading() => isReloading;
    }
}
