using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip backgroundmusic;
    public bool MusicOn=false;


    void Start()
    {
        OnBgMusic();

    }
    public void OnBgMusic()
    {
        MusicOn = true;
        audioSource.clip = backgroundmusic;
        audioSource.Play();

    }
}
