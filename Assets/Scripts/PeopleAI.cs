using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PeopleAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject Target;
    public GameObject UIWeapon;
    public GameObject Player;

    private bool EndTask;
    private bool End;
    // Start is called before the first frame update
    void Start()
    {
        End=true;
        Player= GameObject.FindGameObjectWithTag("Player");
        UIWeapon.gameObject.SetActive(false);
         agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
          agent.destination = Target.transform.position;
     if(End){
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    UIWeapon.gameObject.SetActive(true);
                    EndTask=true;
                    End=false;
                    
                }
            }
        }
        
        
        if(EndTask){
            gameObject.transform.LookAt(Player.transform);
            
        }
        
      }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="Sword"){
            Destroy(other.gameObject);
            UIWeapon.gameObject.SetActive(false);
            Debug.Log("Thanks");
            Destroy(gameObject);
        }
    }
}
