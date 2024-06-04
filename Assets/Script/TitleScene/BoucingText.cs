using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class BoucingText : MonoBehaviour
{

    public TextMeshProUGUI[] uiText;  // ここにTextオブジェクトをアタッチします
    public float speed = 100f;

    private RectTransform[] rectTransform;
    private Vector2 direction = new Vector2 (1,1);

    public float ScreenWidth;
    public float ScreenHeight;

    void Start()
    {
        // for(int i=0;i<uiText.Length; i++)
        // {
        //     rectTransform[i] = uiText[i].GetComponent<RectTransform>();
        //     Debug.Log("aaa");
        // }
        rectTransform[1]=uiText[1].GetComponent<RectTransform>();
    }

    void Update()
    {
        // テキストの位置を更新
        for(int i=0;i<uiText.Length;i++)
        {
            rectTransform[i].localPosition += (Vector3)direction * speed * Time.deltaTime;

            // テキストがCanvasの端に到達したら方向を反転
            if (rectTransform[i].localPosition.x > ScreenWidth || rectTransform[i].localPosition.x < -ScreenWidth)
            {
                direction.x = -direction.x;
                ChangeTextColor(uiText[i]);
            }

            if (rectTransform[i].localPosition.y > ScreenHeight || rectTransform[i].localPosition.y < -ScreenHeight)
            {
                direction.y = -direction.y;
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
