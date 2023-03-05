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
    [SerializeField] private GameObject BestSword;

    [SerializeField] private int Count=0;
    private bool flagCraftSword=true;
    private bool flagCraftBestSword = true;
    private bool flagCraftBow = true;


    void OnTriggerEnter(Collider other)
    {
        if(other.name=="IgnotIron"&& flagCraftSword) {
            flagCraftBestSword = false;
            flagCraftBow=false;
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
                   CSword.name="Sword";
                flagCraftBestSword = true;
                flagCraftBow = true;
            }
        }
        if (other.name == "Wood"&& flagCraftBow) {
            flagCraftSword = false;
            flagCraftBestSword = false;
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
                flagCraftSword = true;
                flagCraftBestSword = true;
            }
        }
        if (other.name == "BestIgnot"&& flagCraftBestSword)
        {
            flagCraftBow = false;
            flagCraftSword = false;
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
                GameObject CBestSword = Instantiate(BestSword, CreateObj.position, Quaternion.Euler(new Vector3(0, 0, 90))) as GameObject;
                CBestSword.name = "BestSword";
                flagCraftBow = true;
                flagCraftSword = true;
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
