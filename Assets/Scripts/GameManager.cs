using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
     public float restartDelay = 3f;
     public GameObject completeLevelUI;
     public PlayerMovement playerMovement;
     bool hasGameEnd = false;

     public void EndGame()
     {
          if (!hasGameEnd)
          {
               Debug.Log("Game over");
               hasGameEnd = true;
               Invoke("Restart", restartDelay);
          }
     }

     public void LevelComplete()
     {
          Debug.Log("Level complete");
          completeLevelUI.SetActive(true);
          DisableMovement();
     }

     void Restart()
     {
          SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }

     void DisableMovement()
     {
          var playerMovement = FindObjectOfType<PlayerMovement>();
          // Set the velocity to zero to stop movement
          playerMovement.rigidBody.velocity = Vector3.zero;

          // Set the angular velocity to zero to stop rotation
          playerMovement.rigidBody.angularVelocity = Vector3.zero;

          playerMovement.enabled = false;
     }

}
