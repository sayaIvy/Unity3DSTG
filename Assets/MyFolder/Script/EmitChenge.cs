using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitChenge : MonoBehaviour
{
    [SerializeField]private GameObject Emit1 = null;
    [SerializeField]private GameObject Emit2 = null;

    private float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        Emit1.SetActive(true);
        Emit2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;//時間を計測
        
        if (time > 3)
        {
            time = 3;
        }
        if (Input.GetButtonUp("Fire-X") || Input.GetKey(KeyCode.G) && time == 3)
        {
            if (Emit1.activeSelf == true)
            {
                Emit1.SetActive(false);
                Emit2.SetActive(true);
                time = 0;
            }
            else if (Emit1.activeSelf == false)
            {
                Emit1.SetActive(true);
                Emit2.SetActive(false);
                time = 0;
            }

        }
    }
}
