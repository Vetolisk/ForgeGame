using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSolder : MonoBehaviour
{
    public AIDestinationSetter AID;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Agent")
        {
            
            AID.target = other.transform;
        }
    }
}
