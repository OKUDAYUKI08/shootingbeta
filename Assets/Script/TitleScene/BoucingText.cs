using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
public class BoucingText : MonoBehaviour
{
    public RectTransform canvas;

    private float[] uisize_x;
    private float[] uisize_y;

    public TextMeshProUGUI[] uiText;  // ここにTextオブジェクトをアタッチします
    public float speed = 100f;

    private RectTransform[] rectTransform;
    private Vector2[] direction;


    private float ScreenWidth;
    private float ScreenHeight;

    void Start()
    {
        ScreenWidth=(canvas.rect.size.x)/2;
        ScreenHeight=(canvas.rect.size.y)/2;
        direction=new Vector2[uiText.Length];
        rectTransform=new RectTransform[uiText.Length];
        uisize_x=new float[uiText.Length];
        uisize_y=new float[uiText.Length];

        for(int i=0;i<uiText.Length; i++)
        {
            rectTransform[i] = uiText[i].GetComponent<RectTransform>();
            uisize_x[i]=rectTransform[i].rect.size.x/2;
            uisize_y[i]=rectTransform[i].rect.size.y/2;
        }


        for(int i=0;i<uiText.Length; i++)
        {
            direction[i]=new Vector2(Random.Range(0, 2) * 2 - 1,Random.Range(0, 2) * 2 - 1);
        }
    }

    void Update()
    {
        // テキストの位置を更新
        for(int i=0;i<uiText.Length;i++)
        {
            rectTransform[i].localPosition += (Vector3)direction[i] * speed * Time.deltaTime;

            // テキストがCanvasの端に到達したら方向を反転
            if (rectTransform[i].localPosition.x > ScreenWidth-uisize_x[i]|| rectTransform[i].localPosition.x < -ScreenWidth+uisize_x[i])
            {
                direction[i].x = -direction[i].x;
                ChangeTextColor(uiText[i]);
            }

            if (rectTransform[i].localPosition.y > ScreenHeight-uisize_y[i]|| rectTransform[i].localPosition.y < -ScreenHeight+uisize_y[i])
            {
                direction[i].y = -direction[i].y;
                ChangeTextColor(uiText[i]);
            }
        }

    }
    void ChangeTextColor(TextMeshProUGUI Text)
    {
        Color newColor = new Color(Random.value, Random.value, Random.value);
        Text.color = newColor;
    }
}
