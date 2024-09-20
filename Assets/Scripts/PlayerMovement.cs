using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;
    public Transform shootPoint;
    public GameObject bulletPrefab;
    public AudioManager audioManager;
    public float bulletSpeed = 50f;
    public float forwardSpeed = 10f;
    public float sideForce = 1f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject playerObject = GameObject.Find("Player");
        rigidBody = playerObject.GetComponent<Rigidbody>();
        audioManager = FindObjectOfType<AudioManager>();

    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.AddForce(Vector3.forward * forwardSpeed, ForceMode.Force);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.AddForce(Vector3.left * sideForce, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.AddForce(Vector3.right * sideForce, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidBody.AddForce(Vector3.forward * sideForce, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = shootPoint.forward * bulletSpeed;
            audioManager.PlaySFX(audioManager.shoot);
        }

        if (rigidBody.position.y < -2)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


    }
}
