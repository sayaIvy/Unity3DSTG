using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dan6LookAt : MonoBehaviour
{
    public GameObject Lookme = null; // 注視したいオブジェクトを事前にInspectorから入れておく

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(Lookme.transform);
    }
}
