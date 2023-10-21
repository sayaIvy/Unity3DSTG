using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultScore : MonoBehaviour
{
    public Text ScoreText1;
    public Text ScoreText2;
    public Text ScoreText3;
    public Text ScoreText4;

    int SScore;
    // Start is called before the first frame update
    void Start()
    {
        SScore = Score.getscore();
        if(ScoreText1.text == "Score:")
        {
            ScoreText1.text = "Score:" + SScore;
        }else if(ScoreText2.text == "Score:")
        {
            ScoreText2.text = "Score:" + SScore;
        }
        else if (ScoreText3.text == "Score:")
        {
            ScoreText3.text = "Score:" + SScore;
        }
        else if (ScoreText4.text == "Score:")
        {
            ScoreText4.text = "Score:" + SScore;
        }
    }
    private void Update()
    {
        if (Input.GetButton("Fire-A"))
        {
            SceneManager.LoadScene("Start");
        }
    }
}
