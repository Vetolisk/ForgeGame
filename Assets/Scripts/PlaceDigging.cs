using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlaceDigging : MonoBehaviour
{
    public List<GameObject> ListPeople;


 
    void Start()
    {
      
    }
    void OnTriggerEnter(Collider other)
   {
    if(other.gameObject.tag=="Player"){
        SceneManager.LoadScene("Cave");
       
     }
      
   }
}
