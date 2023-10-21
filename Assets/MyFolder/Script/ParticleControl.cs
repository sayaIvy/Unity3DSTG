using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControl : MonoBehaviour
{
    // Inspector
    [SerializeField] private ParticleSystem particle;
    private bool particleplay = false;
    [SerializeField] GameObject ScoreUIText = null;
    [SerializeField] int score = 11;

    [SerializeField] AudioClip tamappoi = null;
    [SerializeField] new AudioSource audio = null;
    private bool Atime = true;
    private float Btime = 0;

    void Start()
    {
        particle = this.GetComponent<ParticleSystem>();
        particle.Stop(false, ParticleSystemStopBehavior.StopEmitting);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire-R2") || Input.GetMouseButtonDown(0))
        {
            particle.Play();
            particleplay = true;
        }
        else if (Input.GetButtonUp("Fire-R2") || Input.GetMouseButtonUp(0))
        {
            particle.Stop(false, ParticleSystemStopBehavior.StopEmitting);
            particleplay = false;
            Atime = true;
        }
        if (particleplay == true)
        {
            ScoreUIText.GetComponent<Score>().ScorePulas(ref score);
            Btime += Time.deltaTime;//時間を計測

            if (Atime == true)
            {
                audio.PlayOneShot(tamappoi);
                Atime = false;
            }
            else if (Atime == false && Btime >= 0.1)
            {
                audio.PlayOneShot(tamappoi);
                Btime = 0;
            }
        }
    }
}
