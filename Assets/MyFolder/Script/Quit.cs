using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    [SerializeField] GameObject play = null;
    [SerializeField] GameObject quit = null;
    private float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        quit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire-A"))
        {
            Application.Quit();
        }

        time += Time.deltaTime;//時間を計測

        if (time > 0.1)
        {
            if (Input.GetAxisRaw("PS4ver-D-pad") == 1 || Input.GetAxisRaw("PS4ver-D-pad") == -1)
            {
                play.SetActive(true);
                quit.SetActive(false);
            }
            time = 0;
        }
    }
}
