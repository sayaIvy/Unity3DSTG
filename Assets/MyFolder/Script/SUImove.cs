using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SUImove : MonoBehaviour
{
    private float time = 0;
    private float idou = 10f;
    private float Sidou = 50f;
    public RectTransform a;//RectTransform型の変数aを宣言　作成したテキストオブジェクトをアタッチしておく

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;//時間を計測
        if (time > 0.5 && time < 1.25)
        {
            a.position += (new Vector3(-Sidou, 0, 0));
        }else if (time >= 1.25 && time < 3)
        {
            this.transform.position += (new Vector3(-idou, 0, 0));
        }else if (time >= 3 && time < 3.75)
        {
            a.position += (new Vector3(-Sidou, 0, 0));
        }
        else if (time >= 3.75 && time < 4.5)
        {
            this.transform.position += (new Vector3(-idou, 0, 0));
        }
        else if (time >= 4.5 && time < 10)
        {
            a.position += (new Vector3(-Sidou, 0, 0));
        }
    }
}
