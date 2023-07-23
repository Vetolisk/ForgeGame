using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPeople : MonoBehaviour
{
   public GameObject People;
    void Start()
    {
        GameObject ClonePeople=Instantiate(People,gameObject.transform.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CreatePeople(){
        //Add timer for create
         GameObject ClonePeople=Instantiate(People,gameObject.transform.position,Quaternion.identity);
    }
    
}
