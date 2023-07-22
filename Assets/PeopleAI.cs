using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PeopleAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject Target;
    public GameObject UIWeapon;
    // Start is called before the first frame update
    void Start()
    {
        UIWeapon.gameObject.SetActive(false);
         agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
          agent.destination = Target.transform.position;
          
            if (!agent.pathPending)
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
            {
                UIWeapon.gameObject.SetActive(true);
            }
        }
    }
    }
}
