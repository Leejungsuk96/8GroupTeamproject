using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public static GameManager I;

    public PoolManager pool;

    public int Score =0;
    public Text ScoreText;
    public Text EndScoreText;
    public float GameTime;
    public Text TimeText;
    public GameObject EndPanel;
    public Text EndTimeText;    
    public Text BestScoreText;    
    public GameObject BestMsg;


    private void Awake()
    {
        I = this;
    }


    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        GameTime += Time.deltaTime;
        TimeUP();
        ScoreUP();
        
    }

    void TimeUP()
    {
        TimeText.text = "생존 시간: " + GameTime.ToString("N2");
        EndTimeText.text = "생존 시간: " + GameTime.ToString("N2"); 
    }
    void ScoreUP()
    {
        ScoreText.text = "점수: " + (int)Score;
        EndScoreText.text = "점수: " + (int)Score;
        //일반 똥 + 1
        //스피드 똥 + 2       
    }

    public void GameOver()
    {
        EndPanel.SetActive(true);
        Time.timeScale = 0;

        if (PlayerPrefs.HasKey("MyBestScore") == false)
        {
            PlayerPrefs.SetInt("MyBestScore", Score);
        }
        else
        {
            if (PlayerPrefs.GetInt("MyBestScore") < Score)
            {
                BestMsg.SetActive(true);
                PlayerPrefs.SetInt("MyBestScore", Score);
            }
        }
        BestScoreText.text = "최고 점수: " + PlayerPrefs.GetInt("MyBestScore");        
    }
}
