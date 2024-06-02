using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public GameObject player;
    Transform playertrans;
    // Start is called before the first frame update
    void Start()
    {
        playertrans=player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float my = Input.GetAxis("Mouse Y");
                // Y方向に一定量移動していれば縦回転
        if (Mathf.Abs(my) > 0.001f)
        {
            // 回転軸はカメラ自身のX軸
            transform.RotateAround(player.transform.position, transform.right, -my);
        }
    }
}
