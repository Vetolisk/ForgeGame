using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minecart : MonoBehaviour
{
    [SerializeField] private List<GameObject> ListIgnot;
    public bool flagAllIgnot;
    public bool flagStopOldMove;
    public bool flagMove;
    [SerializeField] private int CountIgnot;
    public float Speed = 3;
    public GameObject OldPos;
   public GameObject  NewPos;
    private void Start()
    {
        OldPos.transform.position = transform.position;
        flagAllIgnot = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name== "IgnotIron")
        {
            ListIgnot.Add(other.gameObject);
            other.transform.SetParent(transform);
            if (ListIgnot.Count<CountIgnot)
            {
                flagStopOldMove = true;
                flagAllIgnot =true;
            }
            else
            {
                flagAllIgnot = false;
            }
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "IgnotIron")
        {
            other.transform.SetParent(null);
            ListIgnot.Remove(other.gameObject);
            if (ListIgnot.Count == 0)
            {
                flagStopOldMove = true;
                flagAllIgnot = true;
            }
        }
    }
    void FixedUpdate()
    {
        if (!flagAllIgnot)
        {
            if (transform.position != NewPos.transform.position)
            {
                    
                transform.position = Vector3.MoveTowards(transform.position, NewPos.transform.position, Time.deltaTime * Speed);
            }
            else
            {
                flagStopOldMove = false;
            }
            

        }
        if (flagAllIgnot)
        {
            if (transform.position != OldPos.transform.position)
            {

                transform.position = Vector3.MoveTowards(transform.position, OldPos.transform.position, Time.deltaTime * Speed);

            }
            else
            {
                flagStopOldMove = true;
            }
            
        }


    }
   
    
}
