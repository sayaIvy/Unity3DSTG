using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform player; // 注目する対象(プレイヤー)

    void Update()
    {
        Vector3 pos = player.position;
        transform.position = new Vector3(pos.x,pos.y + 30f,pos.z);
    }
}
