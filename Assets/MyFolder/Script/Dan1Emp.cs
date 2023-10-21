using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dan1Emp : MonoBehaviour
{
    [SerializeField] AudioClip Danpoi = null;
    [SerializeField] new AudioSource audio = null;
    [SerializeField] float volume = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        audio.volume = volume;
        audio.PlayOneShot(Danpoi);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
