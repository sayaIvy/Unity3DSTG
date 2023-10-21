using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("PS4ver-stickL") < 0)
        {
            Debug.Log("上に移動");
        }
        else if (Input.GetAxisRaw("PS4ver-stickL") > 0)
        {
            Debug.Log("下に移動");
        }
        if (Input.GetAxisRaw("PS4hor-stickL") < 0)
        {
            Debug.Log("左に移動");
        }
        else if (Input.GetAxisRaw("PS4hor-stickL") > 0)
        {
            Debug.Log("右に移動");
        }
        if (Input.GetAxisRaw("PS4ver-stickR") < 0)
        {
            Debug.Log("上を向く");
        }
        if (Input.GetAxisRaw("PS4ver-stickR") > 0)
        {
            Debug.Log("下を向く");
        }
        if (Input.GetAxisRaw("PS4hor-stickR") < 0)
        {
            Debug.Log("左を向く");
        }
        if (Input.GetAxisRaw("PS4hor-stickR") > 0)
        {
            Debug.Log("右を向く");
        }
        if (Input.GetButtonUp("Fire-R2"))
        {
            Debug.Log("射撃");
        }
        if(Input.GetButton("Fire-L2"))
        {
            Debug.Log("ロックオン");
        }
        if (Input.GetButtonUp("Fire-X"))
        {
            Debug.Log("武器切り替え");
        }
        if (Input.GetButtonUp("Fire-R3"))
        {
            Debug.Log("回避");
        }
    }
}
