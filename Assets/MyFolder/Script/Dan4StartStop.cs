using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dan4StartStop : MonoBehaviour
{
    private float time = 0;
    private bool particleplay = true;
    [SerializeField] private ParticleSystem particle = null;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;//時間を計測
        if (time >= 0.7 && particleplay == true)
        {
            particleplay = false;
            particle.Stop(false, ParticleSystemStopBehavior.StopEmitting);
            time = 0;
        }
        else if (time >= 0.1 && particleplay == false)
        {
            particleplay = true;
            particle.Play();
            time = 0;
        }

    }
}
