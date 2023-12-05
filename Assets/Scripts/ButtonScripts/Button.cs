using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject BestScoreBoard;
    public BestSocreBoard _bestSocreBoard;
   
    // Start is called before the first frame update

    private void Awake()
    {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickRetry()
    {
        AudioManager.I.StopBgMusic();
        SceneManager.LoadScene("MinkyuScene");
        Time.timeScale = 1;
    }
    public void OnClickMenu()
    {
        SceneManager.LoadScene("MenuScene");

    }

    public void OnClickBestScoreBoard()
    {
        BestScoreBoard.SetActive(true);
        _bestSocreBoard.OnBoard();
    }

    public void CancelBoard()
    {
        BestScoreBoard.SetActive (false);
    }

    public void ResetBestScore()
    {
        PlayerPrefs.DeleteAll();
        BestScoreBoard.SetActive(false);
    }
    public void GameQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
