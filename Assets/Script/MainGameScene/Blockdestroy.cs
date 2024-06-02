using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Blockdestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other){
        if(other.gameObject.name=="Ball"){
            Destroy(this.gameObject);
            gmmaneger.instance.score+=1;
        }
    }
}
