using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public static int Sscore = 0;
    public GameObject score_object = null; // Textオブジェクト
    [SerializeField] Text ScoreText = null;

    public void ScorePulas(ref int score)
    {
        Sscore = Sscore + score;
        if(Sscore < 0)
        {
            Sscore = 0;
        }
        // テキストの表示を入れ替える
        ScoreText.text = "Score:" + Sscore;
    }
    public static int getscore()
    {
        return Sscore;
    }
}
