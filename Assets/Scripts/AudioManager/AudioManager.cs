using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager I;
    public GameObject audioManager;
    public AudioSource BgMusic;
    public AudioSource PlaySceneMusic;
    public AudioSource EffectSound;
    public AudioClip PlayerGetPillSound;
    public AudioClip PlayerJumpSound;
    public bool IsPlayingBgMusic = false;
    // Start is called before the first frame update

     void Awake()
    {
        I = this;   
        StartBgMusic();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartBgMusic()
    {
       BgMusic.Play();
        DontDestroyOnLoad(audioManager);
    }

    public void StopBgMusic()
    {
        BgMusic.Stop();
    }
    public void StartPlaySceneMusic()
    {
        PlaySceneMusic.Play();
    }
    public void StopPlaySceneMusic()
    {
        PlaySceneMusic.Stop();
    }

    public void JumpSound()
    {
        EffectSound.PlayOneShot(PlayerJumpSound);
    }
    public void GetPillSound()
    {
        EffectSound.PlayOneShot(PlayerGetPillSound);
    }
}
