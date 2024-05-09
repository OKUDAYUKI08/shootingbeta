using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject saucer;
    private float minangle=-45;
    private float maxangle=45;
    // Update is called once per frame
    void Update()
    {
        float currentYAngle = saucer.transform.eulerAngles.z;
		// 現在の角度が180より大きい場合
		if (currentYAngle > 180)
		{
			// デフォルトでは角度は0～360なので-180～180となるように補正
			currentYAngle = currentYAngle - 360;
		}
        if(Input.GetMouseButton(0)){
            if(currentYAngle<45){
                saucer.transform.Rotate(new Vector3(0,0,1));    
            }

        }
        if(Input.GetMouseButton(1)){
            if(currentYAngle>-45){
                saucer.transform.Rotate(new Vector3(0,0,-1));
            }

        }
        
    }
}
