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
    public int BestScore = 0;
    public GameObject IsInvincibility;
    public Text InvincibilityTimeText;
    public float InvincibilityTime = 5f;

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
    public void InvincibilityTimeDown()
    {
        InvincibilityTime = 5f;
        InvincibilityTime -= Time.deltaTime;
        InvincibilityTimeText.text = "무적: " + InvincibilityTime.ToString("N2");
    }

    public void GetItem()
    {
        IsInvincibility.SetActive(true);
        if(InvincibilityTime <= 0)
        {
            IsInvincibility.SetActive(false);
        }

    }

    public void GameOver()
    {
        EndPanel.SetActive(true);
        Time.timeScale = 0;

        if (PlayerPrefs.HasKey("MyBestScore") == false)
        {
            PlayerPrefs.SetInt("MyBestScore", Score);
            BestScore = Score;
            BestMsg.SetActive(true);
        }
        else
        {
            if (PlayerPrefs.GetInt("MyBestScore") < Score)
            {
                BestMsg.SetActive(true);
                PlayerPrefs.SetInt("MyBestScore", Score);
                BestScore= Score;
            }
        }
        BestScoreText.text = "최고 점수: " + PlayerPrefs.GetInt("MyBestScore");        
    }
}
