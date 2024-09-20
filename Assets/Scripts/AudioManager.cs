using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("----Audio Source----")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header("----Audio Clip----")]
    public AudioClip backgroundMusic;
    public AudioClip shoot;
    public AudioClip finish;

    public void PlaySFX(AudioClip audioClip)
    {
        sfxSource.PlayOneShot(audioClip);
    }

    public void StopBackgroundMusic()
    {
        musicSource.Stop();
    }

    private void Start()
    {
        musicSource.clip = backgroundMusic;
        musicSource.Play();
    }

}
