using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TradeWeapon : MonoBehaviour
{
    public GameObject PrefabSwordMen;
    public GameObject PrefabBowMen;
    public GameObject PrefabBestSwordMen;
    [SerializeField] public Transform CreateObj;
    private int i;
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
        if(other.name=="IronSword"){
            Destroy(other.gameObject);
             GameObject SwordMenClone=Instantiate(PrefabSwordMen,new Vector3(CreateObj.position.x+i, CreateObj.position.y, CreateObj.position.z) ,Quaternion.identity) as GameObject;
             i -= 3;
             SwordMenClone.name="SwordMen";
             
        }
        if (other.name == "Bow")
        {
            Destroy(other.gameObject);
            GameObject BowMenClone = Instantiate(PrefabBowMen, new Vector3(CreateObj.position.x + i, CreateObj.position.y, CreateObj.position.z), Quaternion.identity) as GameObject;
            i -= 3;
            BowMenClone.name = "BowMen";

        }
        if (other.name == "BestSword")
        {
            Destroy(other.gameObject);
            GameObject BowMenClone = Instantiate(PrefabBestSwordMen, new Vector3(CreateObj.position.x + i, CreateObj.position.y, CreateObj.position.z), Quaternion.identity) as GameObject;
            i -= 3;
            BowMenClone.name = "BestSwordMen";

        }
    }
    
}
