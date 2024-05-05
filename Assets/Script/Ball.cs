using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Transform BallTransform;
    Rigidbody BallRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
        BallTransform=GetComponent<Transform>();
        BallRigidbody=GetComponent<Rigidbody>();
        BallRigidbody.velocity = new Vector3(0, -5.0f, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other){
        if (other.gameObject.name=="Saucer"){
            Vector3 playerpos=other.transform.position;
            Vector3 ballpos=BallTransform.position;
            Vector3 direction=(ballpos-playerpos).normalized;
            float speed=BallRigidbody.velocity.magnitude;
            BallRigidbody.velocity=direction*speed;
        }
    }
}
