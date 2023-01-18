using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSolder : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Agent")
        {
            
        }
    }
}
