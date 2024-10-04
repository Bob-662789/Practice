using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour
{
    [Header("--------Audio Source--------")]
    [SerializeField] AudioSource Music_Source;
    [SerializeField] AudioSource sfxSource;
    
    
    [Header("--------Audio Clip--------")]
    public AudioClip backgroundMusic;
    public AudioClip shoot;
    public AudioClip collision;
    public AudioClip finish;
    

    // play sound effect
     public void PlaySFX(AudioClip audioClip)
    {
        sfxSource.PlayOneShot(audioClip);
     }

    //PLay BackGround Sound
     private void Start()
    {
        Music_Source.clip = backgroundMusic;
        Music_Source.Play();
    }
    
}
