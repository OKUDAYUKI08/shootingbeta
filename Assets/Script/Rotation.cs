using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject saucer;
    Transform scts;

    private float speed = 5.0f; // 移動速度
    void Start()
    {
        scts=saucer.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            
        }
    }
}
