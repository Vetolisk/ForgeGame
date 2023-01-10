using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftSword : MonoBehaviour
{
    List<GameObject> IronObj=new List<GameObject>();
    [SerializeField] public Transform CreateObj;
    [SerializeField] private GameObject Sword;
    
    [SerializeField] private int Count=0;
    void OnTriggerEnter(Collider other)
    {
        
        if(other.tag=="Iron"){
            IronObj.Add(other.gameObject);
            Count++;
            if(CreateSword(Count)){
                   for(int i=0;i<IronObj.Count;i++){
                     Destroy(IronObj[i].gameObject);
                     IronObj[i]=null;
                    
                   }
                   for(int i=0;i<IronObj.Count;i++){
                     Debug.Log(IronObj[i]);
                   }
                   
                   GameObject CSword=Instantiate(Sword,CreateObj.position,Quaternion.identity) as GameObject;
            }
        }
    }
    public bool CreateSword(int Count){
        if(Count==2){
        return true;
        }else{

        
        return false;
        }
    }
}
