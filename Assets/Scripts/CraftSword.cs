using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftSword : MonoBehaviour
{
  
    List<GameObject> IronObj=new List<GameObject>();
    [SerializeField] public Transform CreateObj;
    [SerializeField] private GameObject Sword;
    [SerializeField] private GameObject Bow;

    [SerializeField] private int Count=0;
    
    
    void OnTriggerEnter(Collider other)
    {
        if(other.name=="IgnotIron"){
            
            Count++;
            IronObj.Add(other.gameObject);
            Destroy(other.gameObject);
            if(CreateSword(Count)){
                   for(int i=0;i<IronObj.Count;i++){
                    if(IronObj[i]!=null){
                     
                     IronObj.Clear();
                    }
                    
                   }
                   Count=0;
                   GameObject CSword=Instantiate(Sword,CreateObj.position,Quaternion.Euler(new Vector3(0, 0, 90))) as GameObject;
                   CSword.name="IronSword";
            }
        }
        if (other.name == "Wood") {
            Count++;
            IronObj.Add(other.gameObject);
            Destroy(other.gameObject);
            if (CreateSword(Count))
            {
                for (int i = 0; i < IronObj.Count; i++)
                {
                    if (IronObj[i] != null)
                    {

                        IronObj.Clear();
                    }
                    
                }
                Count = 0;
                GameObject CBow = Instantiate(Bow, CreateObj.position, Quaternion.Euler(new Vector3(0, 0, 90))) as GameObject;
                CBow.name = "Bow";
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
