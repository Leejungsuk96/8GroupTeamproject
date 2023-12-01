using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int Score =0;
    public Text ScoreText;
    public float GameTime;
    public Text TimeText;
    

    // Start is called before the first frame update
    void Start()
    {
        
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
        TimeText.text = "���� �ð�: " + GameTime.ToString("N2");
    }
    void ScoreUP()
    {
        ScoreText.text = "����: " + (int)Score;
        //�Ϲ� �� + 1
        //���ǵ� �� + 2
    }
}
