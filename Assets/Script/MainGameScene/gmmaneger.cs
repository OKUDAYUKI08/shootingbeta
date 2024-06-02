using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class gmmaneger : MonoBehaviour
{
    public static gmmaneger instance=null;

    public int score;

    private void Awake(){
        if(instance==null){
            instance=this;
            DontDestroyOnLoad(this.gameObject);
        }
        else{
            Destroy(this.gameObject);
        }
    }
}
