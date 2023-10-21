using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchiDamage : MonoBehaviour
{
    ///　DamageUIプレハブ
    [SerializeField] GameObject CDamageUI = null;
    [SerializeField] GameObject ScoreUIText = null;
    [SerializeField] int score = -100000;

    [SerializeField] AudioClip damage = null;
    [SerializeField] new AudioSource audio = null;
    [SerializeField] float volume = 0.5f;

    private void Start()
    {
        audio.volume = volume;
    }
    //　ダメージを受けた場所にダメージUIを表示
    public void Damage(Vector3 pos)
    {
        Instantiate<GameObject>(CDamageUI, pos, Quaternion.identity);
        ScoreUIText.GetComponent<Score>().ScorePulas(ref score);
        audio.PlayOneShot(damage);
    }
}
