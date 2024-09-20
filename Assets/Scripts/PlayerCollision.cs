using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obstacle")
        {
            Debug.Log("hit obstacle");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
