using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestSocreBoard : MonoBehaviour
{
    public Text OnBoardBestScore;

    private void Awake()
    {
        OnBoard();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBoard()
    {
        if(PlayerPrefs.HasKey("MyBestScore") == false)
        {
            OnBoardBestScore.text = "최고 점수: " + (int)0;
        }
        else
        {
            OnBoardBestScore.text = "최고 점수: " + PlayerPrefs.GetInt("MyBestScore");
        }
    }
}
