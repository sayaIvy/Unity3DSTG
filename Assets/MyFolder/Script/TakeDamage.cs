using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    //　DamageUIプレハブ
    [SerializeField]
    private GameObject damageUI = null;
    [SerializeField] GameObject ScoreUIText = null;
    [SerializeField] int score = 100;

    //　ダメージを受けた場所にダメージUIを表示
    public void Damage(Vector3 pos)
    {
        Instantiate<GameObject>(damageUI, pos, Quaternion.identity);
        ScoreUIText.GetComponent<Score>().ScorePulas(ref score);
    }
}
