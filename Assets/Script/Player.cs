using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 30.0f; // 移動速度

    void Start(){

    }

    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime; // 左右の移動
        float zMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime; // 前後の移動
        transform.Translate(xMovement, 0, zMovement); // オブジェクトの位置を更新


    }
}
