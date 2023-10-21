using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSCamera : MonoBehaviour
{
    public Transform verRot;//プレイヤーに合わせる
    public Transform horRot;//プレイヤーに合わせる

    public float AttenRate = 5f; // 減衰比率

    public GameObject lockOnTarget;
    public GameObject player;
    public TarggetCollider targgetcollider;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        targgetcollider = player.GetComponentInChildren<TarggetCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire-L2") == true && targgetcollider.getTarget() != null)//ロックオン
        {
            GameObject target = targgetcollider.getTarget();

            if (target != null)
            {
                lockOnTarget = target;
            }
            else
            {
                lockOnTarget = null;
            }

            if (lockOnTarget)
            {
                Quaternion targetRot = Quaternion.LookRotation(target.transform.position - transform.position);//自機と敵機の角度を計算
                transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, Time.deltaTime * AttenRate); // Lerp減衰
            }
        }
        else//ロックオンされていない
        {
            if (Input.GetAxisRaw("PS4ver-stickR") < 0)//上に動いたか
            {
                verRot.transform.Rotate(Input.GetAxisRaw("PS4ver-stickR") * 2, 0, 0);
            }
            else if (Input.GetAxisRaw("Mouse Y") > 0)
            {
                verRot.transform.Rotate(Input.GetAxisRaw("Mouse Y") * 2, 0, 0);
            }

            if (Input.GetAxisRaw("PS4ver-stickR") > 0)//下に動いたか
            {
                verRot.transform.Rotate(Input.GetAxisRaw("PS4ver-stickR") * 2, 0, 0);
            }
            else if (Input.GetAxisRaw("Mouse Y") < 0)
            {
                verRot.transform.Rotate(Input.GetAxisRaw("Mouse Y") * 2, 0, 0);
            }

            if (Input.GetAxisRaw("PS4hor-stickR") < 0)//左に動いたか
            {
                horRot.transform.Rotate(new Vector3(0, Input.GetAxisRaw("PS4hor-stickR") * 2, 0));
            }
            else if (Input.GetAxisRaw("Mouse X") > 0)
            {
                horRot.transform.Rotate(new Vector3(0, Input.GetAxisRaw("Mouse X") * 2, 0));
            }

            if (Input.GetAxisRaw("PS4hor-stickR") > 0)//右に動いたか
            {
                horRot.transform.Rotate(new Vector3(0, Input.GetAxisRaw("PS4hor-stickR") * 2, 0));
            }
            else if (Input.GetAxisRaw("Mouse X") < 0)
            {
                horRot.transform.Rotate(new Vector3(0, Input.GetAxisRaw("Mouse X") * 2, 0));
            }
        }
    }
}
