using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 30.0f; // 移動速度

    public GameObject player;

    void Update()
    {
        // Playerの前後左右の移動
        float xMovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime; // 左右の移動
        float zMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime; // 前後の移動
        transform.Translate(xMovement, 0, zMovement); // オブジェクトの位置を更新

        // マウスカーソルでPlayerを横回転
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        if (Mathf.Abs(mx) > 0.001f) // X方向に一定量移動していれば横回転
        {
            transform.RotateAround(player.transform.position, Vector3.up, mx); // 回転軸はplayerオブジェクトのワールド座標Y軸
            transform.Rotate(0,mx,0);

        }

        // // Y方向に一定量移動していれば縦回転
        // if (Mathf.Abs(my) > 0.001f)
        // {
        //     // 回転軸はカメラ自身のX軸
        //     transform.RotateAround(player.transform.position, transform.right, -my);
        // }


    }
}
