  using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform respawnPoint; // The location where the player will respawn
    public string obstacleTag = "Obstacle"; // Tag for obstacles
    public string floorTag = "Lava floor"; // Tag for the floor

    private Vector3 initialPosition;

    private void Start()
    {
        // Store the player's initial position for respawning
        if (respawnPoint != null)
        {
            initialPosition = respawnPoint.position;
        }
        else
        {
            // If no respawn point is assigned, default to the player's start position
            initialPosition = transform.position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player collides with an obstacle or the floor
        if (collision.gameObject.CompareTag(obstacleTag) || collision.gameObject.CompareTag(floorTag))
        {
            Respawn();
        }
    }

    private void Respawn()
    {
        // Reset the player's position to the respawn point
        transform.position = initialPosition;

        // Optional: Reset the player's velocity to avoid unwanted movement after respawn
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
