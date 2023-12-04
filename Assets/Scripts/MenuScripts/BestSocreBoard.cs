using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestSocreBoard : MonoBehaviour
{
    public Text OnbBOardBestScore;
    // Start is called before the first frame update
    void Start()
    {
        OnBoard();
    }

    // Update is called once per frame
    void Update()
    {
        OnBoard();
    }

    public void OnBoard()
    {
        OnbBOardBestScore.text = "최고 점수: " + PlayerPrefs.GetInt("MyBestScore");
    }
}
