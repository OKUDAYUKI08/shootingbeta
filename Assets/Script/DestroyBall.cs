using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    void Update(){
        
    }
    void OnCollisionEnter(Collision other){
        if(other.gameObject.name=="Ground"){
            Destroy(this.gameObject);
        }
    }
}
