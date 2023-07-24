using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPeople : MonoBehaviour
{
   public GameObject People;
   public GameObject tavern;
   private int Count=0;
    void Start()
    {
        tavern= GameObject.FindGameObjectWithTag("Tavern");
        //GameObject ClonePeople=Instantiate(People,gameObject.transform.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1)&&Count<=11){
            Debug.Log(Count);
            CreatePeople();
        }
    }
    public void CreatePeople(){
        //Add timer for create
         GameObject ClonePeople=Instantiate(People,gameObject.transform.position,Quaternion.identity);
         ClonePeople.GetComponent<PeopleAI>().agent.destination= tavern.GetComponent<Tavern>().TavernPoint[Count].transform.position;
         Count++;
         
        
    }
    
}
