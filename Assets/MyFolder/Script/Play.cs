using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    [SerializeField] GameObject play = null;
    [SerializeField] GameObject quit = null;
    
    private double time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire-A"))
        {
            SceneManager.LoadScene("Play");
        }

        time += Time.deltaTime;//時間を計測

        if (time > 0.1)
        {
            if (Input.GetAxisRaw("PS4ver-D-pad") == 1 || Input.GetAxisRaw("PS4ver-D-pad") == -1)
            {
                play.SetActive(false);
                quit.SetActive(true);
            }
            time = 0;
        }
    }
}
