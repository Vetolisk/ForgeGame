using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEnemy : MonoBehaviour
{
    public AIDestinationSetter AID;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag== "Solder")
        {
            AID.target = other.gameObject.transform;
        }
    }
}
