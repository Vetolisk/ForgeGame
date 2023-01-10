using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIronIgnot : MonoBehaviour
{
    [SerializeField] public Transform CreateObj;
    public GameObject PrefabIronIgnot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
         if(other.gameObject.tag=="Player"){
            Debug.Log(other.gameObject.tag);
            GameObject IronIgnotClone=Instantiate(PrefabIronIgnot,CreateObj.position,Quaternion.identity) as GameObject;
            IronIgnotClone.name="IgnotIron";
        }
    }
    
}
