using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceDigging : MonoBehaviour
{
    public List<GameObject> ListPeople;
    public GameObject Stand;
    public GameObject[] PrefImage; 
    public Vector3 Pos;
    private float PosX;
    void Start()
    {
        Pos=new Vector3(-0.4f,0.3f,-0.5f);
        PosX=-0.4f;
    }
    void OnTriggerEnter(Collider other)
   {
      if(other.gameObject.name=="BestSword"){
        
        ListPeople.Add(other.gameObject);
        GameObject CloneImage=Instantiate(PrefImage[2],Vector3.zero,Quaternion.identity);
        CloneImage.transform.SetParent(Stand.transform);
        CloneImage.transform.localPosition=new Vector3(PosX,0.3f,-0.5f);
        PosX=PosX+0.18f;
      Destroy(other.gameObject.transform.parent.gameObject);
      //CloneImage.transform.SetParent(Stand.transform);
     }
     if(other.gameObject.name=="Sword"){
        ListPeople.Add(other.gameObject);
        GameObject CloneImage=Instantiate(PrefImage[1],Vector3.zero,Quaternion.identity);
        CloneImage.transform.SetParent(Stand.transform);
        CloneImage.transform.localPosition=new Vector3(PosX,0.3f,-0.5f);
        PosX=PosX+0.18f;
      Destroy(other.gameObject.transform.parent.gameObject);
     }
     if(other.gameObject.name=="Axe"){
        ListPeople.Add(other.gameObject);
        GameObject CloneImage=Instantiate(PrefImage[0],Vector3.zero,Quaternion.identity);
        CloneImage.transform.SetParent(Stand.transform);
        CloneImage.transform.localPosition=new Vector3(PosX,0.3f,-0.5f);
        PosX=PosX+0.18f;
      Destroy(other.gameObject.transform.parent.gameObject);
     }
     if(other.gameObject.name=="Bow"){
        ListPeople.Add(other.gameObject);
        GameObject CloneImage=Instantiate(PrefImage[3],Vector3.zero,Quaternion.identity);
        CloneImage.transform.SetParent(Stand.transform);
        CloneImage.transform.localPosition=new Vector3(PosX,0.3f,-0.5f);
        PosX=PosX+0.18f;
      Destroy(other.gameObject.transform.parent.gameObject);
     }
   }
}
