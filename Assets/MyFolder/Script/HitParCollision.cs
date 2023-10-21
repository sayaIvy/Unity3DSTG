﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitParCollision : MonoBehaviour
{
    private ParticleSystem particle;
    private List<ParticleCollisionEvent> collisionEventList = new List<ParticleCollisionEvent>();

    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    void OnParticleCollision(GameObject obj)
    {
        if (obj.tag == "Player")
        {
            //　イベントの取得
            particle.GetCollisionEvents(obj, collisionEventList);

            //　衝突した位置を取得し、ダメージスクリプトを呼び出す
            foreach (var collisionEvent in collisionEventList)
            {
                Vector3 pos = collisionEvent.intersection;
                obj.GetComponent<CatchiDamage>().Damage(pos);
            }
        }
    }
}
