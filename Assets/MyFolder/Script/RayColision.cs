using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayColision : MonoBehaviour
{
    GameObject obj;
    private void Start()
    {
        // 任意のオブジェクトを取得する
        obj = GameObject.Find("Player");
    }
    void OnCollisionEnter(Collision collision)
    {
        Vector3 pos = obj.transform.position;
        obj.GetComponent<CatchiDamage>().Damage(pos);
    }
}
