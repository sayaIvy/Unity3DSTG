using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dan3Rbun : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle = null;
    private float time = 0;

    [SerializeField] AudioClip reiva = null;
    [SerializeField] new AudioSource audio = null;
    [SerializeField] float volume = 0.5f;

    private void Start()
    {
        audio.volume = volume;
        audio.PlayOneShot(reiva);
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;//時間を計測
        if (time >=1.5 && time <= 2.0)
        {
            transform.Rotate(new Vector3(8.1f, 0, 0));
        }else if(time > 2.0 && time <= 2.1)
        {
            particle.Stop(false, ParticleSystemStopBehavior.StopEmitting);
        }
    }
}
