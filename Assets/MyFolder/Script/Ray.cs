using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour
{
    private float time = 0;
    [SerializeField] float speed = 0;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time < 3.0f)
        {
            transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
        }
    }
}
