using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EminyControl : MonoBehaviour
{
    [SerializeField] float idou = 0;

    private float Etime = 0;
    private float Dtime = 0;

    public GameObject Dan1Enp = null;
    public GameObject Dan6 = null;
    public GameObject Dan6P = null;
    public GameObject Dan3R = null;
    public GameObject RayMove = null;
    public GameObject Dan4TK = null;
    public GameObject Dan4HTK = null;

    private bool Dan2flg = false;
    private bool Dan3flg = false;
    private bool Dan4flg = false;

    [SerializeField] AudioClip owari = null;
    [SerializeField] new AudioSource audio = null;

    void Start()
    {
        Application.targetFrameRate = 60; //FPSを60に設定 
    }

    // Update is called once per frame
    void Update()
    {
        Etime += Time.deltaTime;//時間を計測
        if(Etime >= 5.15 && Etime <=11)
        {
            Danmaku1(ref Etime);
        }
        if(Etime > 11 && Etime <= 20)
        {
            if (Dan2flg == false && Etime < 13)
            {
                Dan2flg = true;
                Danmaku2A();
            }
            else if(Dan2flg == true && Etime >= 13 && Etime <= 15){
                Dan2flg = false;
                Danmaku2B();
            }
            else if (Dan2flg == false && Etime >= 15 && Etime <= 20)
            {
                Dan2flg = true;
                Danmaku2C();
            }
        }
        if(Etime >= 22 && Etime <= 25)
        {
            this.transform.position += (new Vector3(0, -idou * 1.5f, 0));
            Danmaku1(ref Etime);
        }
        if(Etime > 25 && Etime < 32)
        {
            if (Dan3flg == false && Etime < 28)
            {
                Dan3flg = true;
                Danmaku3A();
            }
            else if (Dan3flg == true && Etime >= 28 && Etime < 31)
            {
                Dan3flg = false;
                Danmaku3B();
            }
        }
        if(Etime >= 31 && Etime <= 62)
        {
            if (Dan4flg == false && Etime >= 31 && Etime < 32)
            {
                Dan4flg = true;
                Danmaku4A();
            }
            else if (Dan4flg == true && Etime >= 32 && Etime < 42)
            {
                Dan4flg = false;
                Danmaku4B();
            }
            else if (Dan4flg == false && Etime >= 42 && Etime < 52)
            {
                Dan4flg = true;
                Danmaku4C();
            }
            else if (Dan4flg == true && Etime >= 52 && Etime < 60)
            {
                audio.PlayOneShot(owari);
                Dan4flg = false;
            }
            else if(Etime > 61)
            {
                SceneManager.LoadScene("result");
            }
        }

    }

    void Danmaku1(ref float Etime)
    {
        if(Etime <= 5.25)
        {
            this.transform.position += (new Vector3(0, 0, -idou));
        }else if(Etime > 5.25 && Etime <= 6.75){
            this.transform.position += (new Vector3(idou, 0, 0));
        }else if(Etime > 6.75 && Etime <= 8.25){
            this.transform.position += (new Vector3(-idou, 0, 0));
        }else if(Etime > 8.25 && Etime <= 10.25){
            this.transform.position += (new Vector3(0, 0, idou));
        }


        Dtime += Time.deltaTime;//時間を計測
        if (Dtime > 0.325)
        {
            Vector3 Enemy = this.transform.position;
            GameObject obj = Instantiate(Dan1Enp, Enemy, Quaternion.identity) as GameObject;
            Destroy(obj, 5.0f);
            Dtime = 0;
        }
    }

    void Danmaku2A()
    {
        GameObject obj1 = Instantiate(Dan6, new Vector3(50f, 0f, 50f), Quaternion.Euler(0, 180, 0)) as GameObject;
        GameObject obj2 = Instantiate(Dan6, new Vector3(-50f, 0f, 50f), Quaternion.Euler(0, 90, 0)) as GameObject;
        GameObject obj3 = Instantiate(Dan6, new Vector3(50f, 0f, -50f), Quaternion.Euler(0, -90, 0)) as GameObject;
        GameObject obj4 = Instantiate(Dan6, new Vector3(-50f, 0f, -50f), Quaternion.Euler(0, 0, 0)) as GameObject;
        Destroy(obj1, 15f);
        Destroy(obj2, 15f);
        Destroy(obj3, 15f);
        Destroy(obj4, 15f);

    }
    void Danmaku2B()
    {
        GameObject obj1 = Instantiate(Dan6P, new Vector3(75f, 0f,30f), Quaternion.Euler(0, 180, 0)) as GameObject;
        GameObject obj2 = Instantiate(Dan6P, new Vector3(-75f, 0f, 30f), Quaternion.Euler(0, 90, 0)) as GameObject;
        GameObject obj3 = Instantiate(Dan6P, new Vector3(75f, 0f, -30f), Quaternion.Euler(0, -90, 0)) as GameObject;
        GameObject obj4 = Instantiate(Dan6P, new Vector3(-75f, 0f, -30f), Quaternion.Euler(0, 0, 0)) as GameObject;
        Destroy(obj1, 12f);
        Destroy(obj2, 12f);
        Destroy(obj3, 12f);
        Destroy(obj4, 12f);

    }
    void Danmaku2C()
    {
        GameObject obj1 = Instantiate(Dan6, new Vector3(30f, 80f, 60f), Quaternion.identity) as GameObject;
        GameObject obj2 = Instantiate(Dan6, new Vector3(-30f, 80f, 60f), Quaternion.identity) as GameObject;
        GameObject obj3 = Instantiate(Dan6, new Vector3(30f, -80f, -60f), Quaternion.identity) as GameObject;
        GameObject obj4 = Instantiate(Dan6, new Vector3(-30f, -80f, -60f), Quaternion.identity) as GameObject;

        GameObject obj5 = Instantiate(Dan6P, new Vector3(60f, 80f, 30f), Quaternion.identity) as GameObject;
        GameObject obj6 = Instantiate(Dan6P, new Vector3(-60f, 80f, 30f), Quaternion.identity) as GameObject;
        GameObject obj7 = Instantiate(Dan6P, new Vector3(60f, -80f, -30f), Quaternion.identity) as GameObject;
        GameObject obj8 = Instantiate(Dan6P, new Vector3(-60f, -80f, -30f), Quaternion.identity) as GameObject;

        Destroy(obj1, 10f);
        Destroy(obj2, 10f);
        Destroy(obj3, 10f);
        Destroy(obj4, 10f);
        Destroy(obj5, 10f);
        Destroy(obj6, 10f);
        Destroy(obj7, 10f);
        Destroy(obj8, 10f);
    }
    void Danmaku3A()
    {
        Vector3 Enemy = this.transform.position;
        GameObject obj = Instantiate(Dan3R, Enemy, Quaternion.Euler(-80,0,0)) as GameObject;
        Destroy(obj, 3f);
    }
    void Danmaku3B()
    {
        Vector3 Enemy = this.transform.position;
        GameObject obj = Instantiate(Dan3R, Enemy, Quaternion.Euler(0, 0, -80)) as GameObject;
        Destroy(obj, 3f);
    }
    void Danmaku4A()
    {
        Vector3 Enemy = this.transform.position;
        GameObject obj = Instantiate(RayMove, Enemy, Quaternion.identity) as GameObject;
    }
    void Danmaku4B()
    {
        Vector3 Enemy = this.transform.position;
        GameObject obj = Instantiate(Dan4TK, Enemy, Quaternion.identity) as GameObject;
        Destroy(obj, 10.0f);
    }
    void Danmaku4C()
    {
        Vector3 Enemy = this.transform.position;
        GameObject obj = Instantiate(Dan4HTK, Enemy, Quaternion.identity) as GameObject;
        Destroy(obj, 5.0f);
    }
}
