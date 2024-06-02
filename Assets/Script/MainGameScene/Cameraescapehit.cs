using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraescapehit : MonoBehaviour
{
    private GameObject Parent;

    private Vector3 Position;

    private RaycastHit Hit;

    private float Distance;

    private int Mask;

    void Start()
    {
        Parent = transform.root.gameObject;//親オブジェクトを取得

        Position = transform.localPosition;//親オブジェクトとの相対位置座標

        Distance = Vector3.Distance(Parent.transform.position, transform.position);//二つのポジションの距離を計算

        Mask = ~(1 << LayerMask.NameToLayer("Player"));
    }

    void Update()
    {
        if(Physics.CheckSphere(Parent.transform.position, 0.1f, Mask))
        {
            transform.position = Vector3.Lerp(transform.position, Parent.transform.position, 1);
        }
        else if (Physics.SphereCast(Parent.transform.position, 0.1f, (transform.position - Parent.transform.position).normalized, out Hit, Distance, Mask))
        {
            transform.position = Parent.transform.position + (transform.position - Parent.transform.position).normalized * Hit.distance;
        }
        else
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, Position, 1);
        }
    }
}