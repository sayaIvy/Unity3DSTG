using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarfighterControl : MonoBehaviour
{
    [SerializeField] float X_Speed = 30f;
    [SerializeField] float Y_Speed = 30f;
    [SerializeField] float Z_Speed = 30f;
    [SerializeField] float stopper = 5.0f;
    [SerializeField] float BurstSpeed = 240f;
    float moveX = 0f;
    float moveZ = 0f;
    float moveY = 0f;

    bool kaihi = false;
    float Ktime = 0;

    Rigidbody playerrigid;
    public GameObject mainCamera;

    [SerializeField] AudioClip kasoku = null;
    [SerializeField] new AudioSource audio = null;
    [SerializeField] float volume = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        playerrigid = GetComponent<Rigidbody>();
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        audio.volume = volume;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("PS4ver-stickL") < 0 || Input.GetAxisRaw("PS4ver-stickL") > 0)
        {
            moveZ = -Input.GetAxisRaw("PS4ver-stickL");
        }
        else if (Input.GetKey(KeyCode.W))
        {
            moveZ = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveZ = -1;
        }
        else
        {
            moveZ = 0;
        }
        //左右に進む
        if (Input.GetAxisRaw("PS4hor-stickL") < 0 || Input.GetAxisRaw("PS4hor-stickL") > 0)
        {
            moveX = Input.GetAxisRaw("PS4hor-stickL");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveX = 1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveX = -1;
        }
        else
        {
            moveX = 0;
        }
        //上昇下降
        if (Input.GetButton("Fire-R1") || Input.GetKey(KeyCode.E))
        {
            moveY = 1;
        }
        else if (Input.GetButton("Fire-L1") || Input.GetKey(KeyCode.C))
        {
            moveY = -1;
        }
        else
        {
            moveY = 0;
        }
    }

    void FixedUpdate()
    {
        Vector3 moveVector = new Vector3(X_Speed * moveX, Y_Speed * moveY, Z_Speed * moveZ);    // 通常速度
        Vector3 BurstVector = new Vector3(BurstSpeed * moveX, BurstSpeed * moveY, BurstSpeed * moveZ);//回避速度


        Vector3 cameraForward = mainCamera.transform.forward;  ///常に自機の正面が方向の基準
        Vector3 cameraRight = mainCamera.transform.right;
        Vector3 cameraUp = mainCamera.transform.up;

        moveVector = (cameraRight.normalized * moveVector.x + cameraForward.normalized * moveVector.z + cameraUp.normalized * moveVector.y);
        BurstVector = (cameraRight.normalized * BurstVector.x + cameraForward.normalized * BurstVector.z + cameraUp.normalized * BurstVector.y);

        if (Input.GetButtonDown("Fire-R3") && kaihi == false)//回避
        {
            kaihi = true;
            Ktime += Time.deltaTime;//時間を計測
            audio.PlayOneShot(kasoku);

            playerrigid.AddForce(stopper * (BurstVector - playerrigid.velocity));
        }
        else if(kaihi == false)//通常移動
        {
            playerrigid.AddForce(stopper * (moveVector - playerrigid.velocity));        }
        else if (kaihi == true)
        {
            //～秒経ったら
            if (Ktime >= 0.25)
            {
                kaihi = false;
                Ktime = 0;
            }
            else
            {
                Ktime += Time.deltaTime;//時間を計測

                playerrigid.AddForce(stopper * (BurstVector - playerrigid.velocity));            }
        }
    }
}