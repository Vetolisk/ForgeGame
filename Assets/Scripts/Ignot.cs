using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignot : MonoBehaviour
{
    public bool Hot=false;
    [SerializeField] private float timeLeft;
    [SerializeField] private Color targetColor;
    public void HeatinIgnotRed()
    {
        if (timeLeft <= Time.deltaTime)
        {
            gameObject.GetComponent<Renderer>().material.color = targetColor;
            Hot = true;
            gameObject.name = "BestIgnot";
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.Lerp(gameObject.GetComponent<Renderer>().material.color, targetColor, Time.deltaTime / timeLeft);
            timeLeft -= Time.deltaTime;
            Debug.Log(timeLeft);
        }

    }
}
