using UnityEngine;

public class Shooting_Method : MonoBehaviour
{
    public Audio_Manager audioManager;
    public GameObject bulletPrefab; // Changed variable name to avoid conflict
    public Transform firePoint;
    public float bulletSpeed = 9000f;

    void Start()
    {
        bulletPrefab = GameObject.FindWithTag("Bullet"); // Assign the bullet prefab at start
         audioManager = FindObjectOfType<Audio_Manager>();

    }
 
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Default is left mouse button or Ctrl
        {
            Shoot();
        }
    }
 
    void Shoot()
    { 
        audioManager.PlaySFX(audioManager.shoot);
        // Instantiate bulletPrefab at firePoint's position and rotation
        GameObject bulletInstance = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Get the Rigidbody component of the bullet and add force to it
        Rigidbody rb = bulletInstance.GetComponent<Rigidbody>();
        rb.velocity = firePoint.forward * bulletSpeed;

        // Destroy the bullet after 5 seconds to clean up
        Destroy(bulletInstance, 5f);
    
    }
}
