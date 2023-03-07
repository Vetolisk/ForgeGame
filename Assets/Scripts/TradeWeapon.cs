using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TradeWeapon : MonoBehaviour
{
    public List<GameObject> Weapons;
    public float PosStand;
    public GameObject PrefabSwordMen;
    public GameObject PrefabBowMen;
    public GameObject PrefabBestSwordMen;

    public GameObject StandWeapon;
    [SerializeField] public Transform CreateObj;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        PosStand=2.5f;
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.name=="Sword"||other.name == "Bow"||other.name == "BestSword"){
        if(i<11){
        i++;
        Debug.Log(PosStand);
        Weapons.Add(other.gameObject);
        other.gameObject.GetComponent<Rigidbody>().isKinematic=true;
        Destroy(other.gameObject.GetComponent<ObjectGrabbable>());
        other.gameObject.transform.SetParent(StandWeapon.transform);       
        other.gameObject.transform.localPosition=new Vector3(PosStand, 0, 0.35f);
        PosStand-=0.5f;
        Debug.Log(PosStand);
        other.gameObject.transform.eulerAngles = new Vector3(0, 180, 0);
        }
        }

       /* if(other.name=="IronSword"){
            Destroy(other.gameObject);
             GameObject SwordMenClone=Instantiate(PrefabSwordMen,new Vector3(CreateObj.position.x+i, CreateObj.position.y, CreateObj.position.z) , Quaternion.Euler(new Vector3(0, 180, 0))) as GameObject;
             i -= 3;
             SwordMenClone.name="SwordMen";
             
        }
        if (other.name == "Bow")
        {
            Destroy(other.gameObject);
            GameObject BowMenClone = Instantiate(PrefabBowMen, new Vector3(CreateObj.position.x + i, CreateObj.position.y, CreateObj.position.z), Quaternion.Euler(new Vector3(0, 180, 0))) as GameObject;
            i -= 3;
            BowMenClone.name = "BowMen";

        }
        if (other.name == "BestSword")
        {
            Destroy(other.gameObject);
            GameObject BowMenClone = Instantiate(PrefabBestSwordMen, new Vector3(CreateObj.position.x + i, CreateObj.position.y, CreateObj.position.z), Quaternion.Euler(new Vector3(0, 180, 0))) as GameObject;
            i -= 3;
            BowMenClone.name = "BestSwordMen";

        }
        */
    }
    
}
