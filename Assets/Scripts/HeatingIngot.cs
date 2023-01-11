using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR;
using UnityEngine;

public class HeatingIngot : MonoBehaviour
{
    [SerializeField] private int capacity;
    [SerializeField] private float timeLeft;
    [SerializeField] private Color targetColor;
    [SerializeField] List<GameObject> listGameobjectIgnot;
    private void OnTriggerEnter(Collider other)
    {
        if (listGameobjectIgnot.Count<4)
        {
            if (other.name == "IgnotIron")
            {
                listGameobjectIgnot.Add(other.gameObject);

            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "IgnotIron")
        {
            listGameobjectIgnot.Remove(other.gameObject);

        }
    }
    private void Update()
    {
        if (listGameobjectIgnot!=null) {
            for (int i = 0; i < listGameobjectIgnot.Count; i++)
            {
                listGameobjectIgnot[i].GetComponent<Ignot>().HeatinIgnotRed();
                if (listGameobjectIgnot[i].GetComponent<Ignot>().Hot)
                {
                    listGameobjectIgnot.Remove(listGameobjectIgnot[i]);
                }
            }
        }
        
    }
    
}
