using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int Score =0;
    public Text ScoreText;
    public Text EndScoreText;
    public float GameTime;
    public Text TimeText;
    public GameObject EndPanel;
    public bool GameOver = false;

    // Start is called before the first frame update
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
        GameEnd();
    }

    void TimeUP()
    {
        TimeText.text = "���� �ð�: " + GameTime.ToString("N2");
    }
    void ScoreUP()
    {
        ScoreText.text = "����: " + (int)Score;
        EndScoreText.text = "����: " + (int)Score;
        //�Ϲ� �� + 1
        //���ǵ� �� + 2
        if (GameOver == true)
        {
            
        }
    }

     public void GameEnd()
    {
        if(GameTime > 10f)
        {
            Time.timeScale = 0;
            GameOver = true;
            EndPanel.SetActive(true);
        }
       
    }
}
