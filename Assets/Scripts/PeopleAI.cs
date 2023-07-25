using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PeopleAI : MonoBehaviour
{
    public SpawnPeople sp;
    public NavMeshAgent agent;
    public GameObject Target;
    public GameObject TargetToDig;
    public GameObject Walk;

    public List <GameObject> UIWeapon;
    public GameObject Player;
    public GameObject Weapon;

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
        // Если нет оружия то идти в кузницу, иначе идти заниматься делом
        if(Weapon==null){    
         if(agent.remainingDistance<=agent.stoppingDistance){ 
                WaitTime();

        }  
        }
    }
    public void TavernStop(){

    }
        void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{other.gameObject.name} == {UIWeapon[Count].gameObject.name}");
        if(other.gameObject.name==UIWeapon[Count].gameObject.name){
            Weapon=other.gameObject;
            other.gameObject.transform.SetParent(gameObject.transform);
            other.gameObject.SetActive(false);
            //Destroy(other.gameObject);
            UIWeapon[Count].gameObject.SetActive(false);          
            Debug.Log("Thanks");
            PlayerChar.Money=PlayerChar.Money+20;
            agent.SetDestination(Walk.transform.position);
            //sp.CreatePeople();
        }
          if(other.gameObject.name==UIWeapon[Count].gameObject.name){
            gameObject.transform.name="Dwarf";
            Weapon=other.gameObject;
            other.gameObject.transform.SetParent(gameObject.transform);
            other.gameObject.SetActive(false);
            //Destroy(other.gameObject);
            UIWeapon[Count].gameObject.SetActive(false);          
            Debug.Log("Thanks");
            PlayerChar.Money=PlayerChar.Money+20;
            agent.SetDestination(TargetToDig.transform.position);
            //sp.CreatePeople();
        }
    }
    public void Stop(){
        agent.isStopped=true;
        agent.speed=0;
    }
    public void NextPointTavern(){
        agent.SetDestination(Target.transform.position);
        UIWeapon[Count].gameObject.SetActive(true);                
        gameObject.transform.LookAt(Player.transform);
             
                    
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
