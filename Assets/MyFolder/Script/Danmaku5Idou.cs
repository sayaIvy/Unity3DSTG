using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danmaku5Idou : MonoBehaviour
{
    [SerializeField] float idou = 5;

    // Update is called once per frame
    void Update()
    {
        this.transform.position += (new Vector3(idou, 0, 0));
    }
}
