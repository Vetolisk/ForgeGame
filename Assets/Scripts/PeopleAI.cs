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

    public PlayerСharacteristics PlayerChar;

    private float timeRemaining;
    [SerializeField] private float oldtime;
    private int Count;
    // Start is called before the first frame update
    void Start()
    {
        Count=Random.Range(0,2);
        Player= GameObject.FindGameObjectWithTag("Player");
        PlayerChar=Player.GetComponent<PlayerСharacteristics>();
        agent = GetComponent<NavMeshAgent>();
        agent.isStopped=false;
        oldtime= Random.Range(10,30);
        timeRemaining = oldtime;

    }

    // Update is called once per frame
    void Update()
    { 
        //Проверка пути
        
        /*
        if (agent.remainingDistance<=agent.stoppingDistance)
        {
                    UIWeapon[Count].gameObject.SetActive(true);
                    EndTask=true;
                    End=false;   
                    if(EndTask){
                        gameObject.transform.LookAt(Player.transform);
                        Debug.Log(EndTask);
                        EndTask=false;
             
                    }           
        } */    
     

         if(agent.remainingDistance<=agent.stoppingDistance){ 
                WaitTime();                    
        }  
     
    
    }
    public void TavernStop(){

    }
        void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="Sword"){
            Destroy(other.gameObject);
             UIWeapon[Count].gameObject.SetActive(false);
            Debug.Log("Thanks");
            PlayerChar.Money=PlayerChar.Money+20;
            Destroy(gameObject);
            sp.CreatePeople();
        }
        if(other.gameObject.name=="Bow"){
            Destroy(other.gameObject);
             UIWeapon[Count].gameObject.SetActive(false);
            Debug.Log("Thanks");
            PlayerChar.Money=PlayerChar.Money+30;
            Destroy(gameObject);
            sp.CreatePeople();
        }
         if(other.gameObject.name=="BestSword"){
            Destroy(other.gameObject);
             UIWeapon[Count].gameObject.SetActive(false);
            Debug.Log("Thanks");
            PlayerChar.Money=PlayerChar.Money+40;
            Destroy(gameObject);
            sp.CreatePeople();
        }
    }
    public void Stop(){
        agent.isStopped=true;
        agent.speed=0;
    }
    public void NextPointTavern(){
        agent.SetDestination(Target.transform.position);
    }
    public void WaitTime(){
         if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {   
            NextPointTavern();                            
        }
    }
}
