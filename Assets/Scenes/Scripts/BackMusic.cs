using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class BackMusic : MonoBehaviour
{
    GameObject BackGroundMusic;
    AudioSource backmusic;
    public bool MusicOn;

    

    void Awake()
    {
        MusicOn = true;

        if (MusicOn == true)
        {
            BackGroundMusic = GameObject.Find("BackGroundMusic");
            backmusic = BackGroundMusic.GetComponent<AudioSource>();
            DontDestroyOnLoad(BackGroundMusic);
        }
        else
        {
            MusicOn=false;
        }
        
    }
    
}
