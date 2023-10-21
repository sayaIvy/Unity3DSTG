using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TarggetCollider : MonoBehaviour
{
    [SerializeField]
    public GameObject target;

    protected void OnTriggerEnter(Collider tageG)
    {
        if (tageG.gameObject.tag == "Enemy")
        {
            target = tageG.gameObject;
            Debug.Log("ロックオン範囲内");
        }
    }

    protected void OnTriggerExit(Collider tageG)
    {
        if (tageG.gameObject.tag == "Enemy")
        {
            target = null;
            Debug.Log("ロックオン範囲外");
        }
    }

    public GameObject getTarget()
    {
        return this.target;
    }
}
