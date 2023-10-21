using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSE : MonoBehaviour
{
    [SerializeField] AudioClip Click = null;
    [SerializeField] AudioClip Select = null;
    [SerializeField] new AudioSource audio = null;
    private double time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;//時間を計測

        if (Input.GetButton("Fire-A"))
        {
            audio.PlayOneShot(Click);
        }
        if (time > 0.1)
        {
            if (Input.GetAxisRaw("PS4ver-D-pad") == 1 || Input.GetAxisRaw("PS4ver-D-pad") == -1)
            {
                audio.PlayOneShot(Select);
            }
            time = 0;
        }
    }
}
