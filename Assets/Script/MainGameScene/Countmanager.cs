using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Countmanager : MonoBehaviour
{
    public TextMeshProUGUI count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count.text=gmmaneger.instance.score.ToString();
    }
}