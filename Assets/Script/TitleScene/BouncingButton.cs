using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BouncingButton : MonoBehaviour
{
    public Button[] uibutton;  // ここにTextオブジェクトをアタッチします
    public float speed = 100f;

    private RectTransform[] rectTransform;
    private Vector2 direction = new Vector2 (1,1);

    public float ScreenWidth;
    public float ScreenHeight;

    void Start()
    {
        // for(var i=0;i<uibutton.Length;i++){
        //     rectTransform[i]=uibutton[i].GetComponent<RectTransform>();
        // }
        rectTransform[0]=uibutton[0].GetComponent<RectTransform>();
        rectTransform[1]=uibutton[1].GetComponent<RectTransform>();
    }

    void Update()
    {
        // テキストの位置を更新
        for(var i = 0; i < uibutton.Length ; i++)
        {
            rectTransform[i].localPosition += (Vector3)direction * speed * Time.deltaTime;

            // テキストがCanvasの端に到達したら方向を反転
            if (rectTransform[i].localPosition.x > ScreenWidth || rectTransform[i].localPosition.x < -ScreenWidth)
            {
                direction.x = -direction.x;
            }

            if (rectTransform[i].localPosition.y > ScreenHeight || rectTransform[i].localPosition.y < -ScreenHeight)
            {
                direction.y = -direction.y;
            }
        }

    }
}
