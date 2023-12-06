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
    private bool PlayerIsInvincibility = false;
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
        if (PlayerIsInvincibility)
        {
            InvincibilityTime -= Time.deltaTime;
            InvincibilityTimeDown();
            if(InvincibilityTime <= 0)
            {
                ResetInvincibility();
            }
        }
        
    }

    void TimeUP()
    {
        TimeText.text = "���� �ð�: " + GameTime.ToString("N2");
        EndTimeText.text = "���� �ð�: " + GameTime.ToString("N2"); 
    }
    void ScoreUP()
    {
        ScoreText.text = "����: " + (int)Score;
        EndScoreText.text = "����: " + (int)Score;
        //�Ϲ� �� + 1
        //���ǵ� �� + 2       
    }
    public void InvincibilityTimeDown()
    {       
        PlayerIsInvincibility = true;
        IsInvincibility.SetActive(true);
        InvincibilityTimeText.text = "����: " + InvincibilityTime.ToString("N2");        
    }        
    public void ResetInvincibility()
    {
        if(InvincibilityTime <= 0) 
        {                
            PlayerIsInvincibility = false;
            IsInvincibility.SetActive(false);
            InvincibilityTime = 5f;
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
        BestScoreText.text = "�ְ� ����: " + PlayerPrefs.GetInt("MyBestScore");        
    }
}
