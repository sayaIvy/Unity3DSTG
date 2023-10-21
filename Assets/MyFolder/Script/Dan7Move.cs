using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dan7Move : MonoBehaviour
{
    private float time = 0;
    private float idou1 = 3f;
    private float idou2 = 0.5f;

    [SerializeField] private ParticleSystem particle = null;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;//時間を計測
        if (time >= 1 && time < 4)
        {
            this.transform.position += (new Vector3(idou1, 0, 0));
        }else if(time >= 4 && time < 5)
        {
            particle.Pause();
        }else if(time >= 5 && time < 8)
        {
            this.transform.position += (new Vector3(0, idou2, 0));
        }

    }
}
