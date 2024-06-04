using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BouncingButton : MonoBehaviour
{
    public RectTransform canvas;

    private float[] uisize_x;

    private float[] uisize_y;
    public Button[] uibutton;  // ここにTextオブジェクトをアタッチします
    public float speed = 100f;

    private RectTransform[] rectTransform;
    private Vector2[] direction ;

    private float ScreenWidth;
    private float ScreenHeight;



    void Start()
    {
        ScreenWidth=(canvas.rect.size.x)/2;
        ScreenHeight=(canvas.rect.size.y)/2;
        rectTransform = new RectTransform[uibutton.Length];
        uisize_x=new float[uibutton.Length];
        uisize_y=new float[uibutton.Length];
        direction=new Vector2[uibutton.Length];
        for(var i=0;i<uibutton.Length;i++){
            rectTransform[i]=uibutton[i].GetComponent<RectTransform>();
            uisize_x[i]=rectTransform[i].rect.size.x/2;
            uisize_y[i]=rectTransform[i].rect.size.y/2;
        }
        for(int i=0;i<uibutton.Length; i++)
        {
            direction[i]=new Vector2(Random.Range(0, 2) * 2 - 1,Random.Range(0, 2) * 2 - 1);
        }
    }

    void Update()
    {
        //テキストの位置を更新
        for(var i = 0; i < uibutton.Length ; i++)
        {
            rectTransform[i].localPosition += (Vector3)direction[i] * speed * Time.deltaTime;

            // テキストがCanvasの端に到達したら方向を反転
            if (rectTransform[i].localPosition.x > ScreenWidth-uisize_x[i] || rectTransform[i].localPosition.x < -ScreenWidth+uisize_x[i])
            {
                direction[i].x = -direction[i].x;
            }

            if (rectTransform[i].localPosition.y > ScreenHeight-uisize_y[i] || rectTransform[i].localPosition.y < -ScreenHeight+uisize_y[i])
            {
                direction[i].y = -direction[i].y;
            }
        }
    }
}
