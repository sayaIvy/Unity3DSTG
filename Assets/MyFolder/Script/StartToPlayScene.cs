using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartToPlayScene : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Fire-A"))
        {
            PlayBottunClick();
        }
    }

    public void PlayBottunClick()
    {
        SceneManager.LoadScene("Play");
    }
}
