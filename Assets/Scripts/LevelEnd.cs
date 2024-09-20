using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    public GameManager gameManager;
    public AudioManager audioManager;

    void Awake()
    {
        audioManager = FindObjectOfType<AudioManager>();
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            gameManager.LevelComplete();
            audioManager.StopBackgroundMusic();
            audioManager.PlaySFX(audioManager.finish);
        }
    }
}