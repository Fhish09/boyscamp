using UnityEngine;

namespace Boyscamp.Weapons
{
    public class WeaponBase : MonoBehaviour
    {
        [Header("Weapon Stats")]
        public string weaponName = "Assault Rifle";
        public int damage = 25;
        public float fireRate = 0.1f;
        public int magazineSize = 30;
        public float reloadTime = 2f;
        public float range = 100f;

        [Header("Current State")]
        public int currentAmmo;
        public bool isReloading = false;

        private float nextTimeToFire = 0f;

        void Start()
        {
            currentAmmo = magazineSize;
        }

        public virtual void Shoot()
        {
            if (isReloading || currentAmmo <= 0) return;
            if (Time.time < nextTimeToFire) return;

            nextTimeToFire = Time.time + fireRate;
            currentAmmo--;

            // Raycast shooting
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            if (Physics.Raycast(ray, out RaycastHit hit, range))
            {
                Debug.Log($"Hit: {hit.collider.name}");
                // Apply damage here
            }
        }

        public virtual void Reload()
        {
            if (isReloading || currentAmmo == magazineSize) return;
            isReloading = true;
            Invoke(nameof(FinishReload), reloadTime);
        }

        void FinishReload()
        {
            currentAmmo = magazineSize;
            isReloading = false;
        }
    }
}
