using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facerotation : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        // マウスの移動量を取得
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
       
    
        //カーソルの向きの初期化
        if (Input.GetKeyDown(KeyCode.V))
        {
            this.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }


        // X方向に一定量移動していれば横回転
        if (Mathf.Abs(mx) > 0.001f)
        {
            // 回転軸はワールド座標のY軸
            transform.RotateAround(player.transform.position, Vector3.up, mx);

        }
    }
}
