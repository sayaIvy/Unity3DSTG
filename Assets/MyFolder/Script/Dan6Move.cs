using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dan6Move : MonoBehaviour
{
    private float time = 0;
    private float idou = 0.5f;

    

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;//時間を計測
        if (time >= 1 && time < 3)
        {
            this.transform.position += (new Vector3(idou, 0, 0));
        }
        else if (time >= 4 && time < 6)
        {
            Quaternion rot = Quaternion.Euler(0, 90, 0);
            this.transform.rotation = rot;
            this.transform.position += (new Vector3(idou, 0, 0));
        }
        else if (time >= 7 && time < 9)
        {
            Quaternion rot = Quaternion.Euler(0, 90, 0);
            this.transform.rotation = rot;
            this.transform.position += (new Vector3(idou, 0, 0));
        }
        else if (time >= 10 && time < 12)
        {
            Quaternion rot = Quaternion.Euler(0, 90, 0);
            this.transform.rotation = rot;
            this.transform.position += (new Vector3(idou, 0, 0));
        }
        else if (time >= 13 && time < 15)
        {
            Quaternion rot = Quaternion.Euler(0, 90, 0);
            this.transform.rotation = rot;
            this.transform.position += (new Vector3(idou, 0, 0));
        }

    }
}
