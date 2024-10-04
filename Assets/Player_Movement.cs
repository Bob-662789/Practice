using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb;

    public Transform playerTransform;
    public float forwardForce = 2000f;

    public float sidewaysForce = 500f;
    public float upwardsForce = 550f;

    public GameObject bulletPrefab;

    private bool isGrounded = true;

    void Start()
    {
        GameObject playerObject = GameObject.Find("Player");
        playerTransform = playerObject.GetComponent<Transform>();
    }
    



    void FixedUpdate()
    {
        // Constant forward movement
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // --- WASD Movement (Keyboard Controls) ---
        
        // Move Right (D key)
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        // Move Left (A key)
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        // Jump (Space key)
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, upwardsForce, 0, ForceMode.Impulse);
            isGrounded = false;
        }

        // --- PS5 Controller Input ---

        // Move Right (PS5 Left Stick)
        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Move Left (PS5 Left Stick)
        if (Input.GetAxis("Horizontal") < -0.1f)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Jump (PS5 X Button)
        if (isGrounded && Input.GetButtonDown("PS5_Jump"))  // Detects PS5 X button for jump
        {
            rb.AddForce(0, upwardsForce, 0, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    // Check for collision with the ground
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
