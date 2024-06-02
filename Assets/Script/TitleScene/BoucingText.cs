using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BoucingText : MonoBehaviour
{
    public TextMeshProUGUI uiText;  // ここにTextオブジェクトをアタッチします
    public float speed = 100f;

    private RectTransform rectTransform;
    private Vector2 direction = new Vector2 (1,1);

    public float ScreenWidth;
    public float ScreenHeight;

    void Start()
    {
        rectTransform = uiText.GetComponent<RectTransform>();
    }

    void Update()
    {
        Debug.Log(direction);
        // テキストの位置を更新
        rectTransform.localPosition += (Vector3)direction * speed * Time.deltaTime;

        // テキストがCanvasの端に到達したら方向を反転
        if (rectTransform.localPosition.x > ScreenWidth || rectTransform.localPosition.x < -ScreenWidth)
        {
            direction.x = -direction.x;
            ChangeTextColor();
        }

        if (rectTransform.localPosition.y > ScreenHeight || rectTransform.localPosition.y < -ScreenHeight)
        {
            direction.y = -direction.y;
            ChangeTextColor();
        }
    }
    void ChangeTextColor()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value);
        uiText.color = newColor;
    }
}
