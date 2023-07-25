using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDIg : MonoBehaviour
{
   
    void OnTriggerEnter(Collider other)
   {
      if(other.gameObject.name=="SolderMesh"){
      Destroy(other.gameObject.transform.parent.gameObject);
     }
   }
}
