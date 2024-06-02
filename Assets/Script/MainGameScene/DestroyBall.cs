using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using unityroom.Api;

public class DestroyBall : MonoBehaviour
{
    void Update(){
        
    }
    void OnCollisionEnter(Collision other){
        if(other.gameObject.name=="Ground"){
            Destroy(this.gameObject);
            UnityroomApiClient.Instance.SendScore(1, gmmaneger.instance.score, ScoreboardWriteMode.HighScoreDesc);
        }
    }
}
