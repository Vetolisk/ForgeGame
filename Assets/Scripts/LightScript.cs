using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    [SerializeField] Color[] myColors;
    int colorIndex=0;
    float t=0f;
    [SerializeField] [Range(0f,2f)] float  LerpTime;

    int len;
    // Start is called before the first frame update
    void Start()
    {
        len=myColors.Length;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Light>().color=Color.Lerp( gameObject.GetComponent<Light>().color,myColors[colorIndex],LerpTime*Time.deltaTime);
        t= Mathf.Lerp(t,1f,LerpTime*Time.deltaTime);
        if(t>.9f){
            t=0f;
            colorIndex++;
            colorIndex=(colorIndex>=len) ? 0 : colorIndex;
        }
    }
  
}

