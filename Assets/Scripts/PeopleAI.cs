using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PeopleAI : MonoBehaviour
{
    public SpawnPeople sp;
    public NavMeshAgent agent;
    public GameObject Target;
    public List <GameObject> UIWeapon;
    public GameObject Player;

    private bool EndTask;
    private bool End;
    private int Count;
    // Start is called before the first frame update
    void Start()
    {
        Count=Random.Range(0,2);
        End=true;
        Player= GameObject.FindGameObjectWithTag("Player");
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
                    UIWeapon[Count].gameObject.SetActive(true);
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
             UIWeapon[Count].gameObject.SetActive(false);
            Debug.Log("Thanks");
            Destroy(gameObject);
            sp.CreatePeople();
        }
    }
}
