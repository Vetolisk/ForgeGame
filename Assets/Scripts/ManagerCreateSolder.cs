using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ManagerCreateSolder : MonoBehaviour
{
    public int i;
    public int j=-5;
    public GameObject WeaponRack;
    public TextMeshProUGUI text;
    public GameObject Solder;
    public GameObject TradeW;

    public GameObject SpawnSolder;
    // Start is called before the first frame update
    void Start()
    {
        if( WeaponRack.GetComponent<TradeWeapon>().Weapons.Count==0){
            text.text="No Weapon";
        }else{
        text.text=WeaponRack.GetComponent<TradeWeapon>().Weapons[0].name;
        }
    }


    public void CreateButton(){
        
        
       if(WeaponRack.GetComponent<TradeWeapon>().Weapons.Count>0){
        j+=5;
        if(WeaponRack.GetComponent<TradeWeapon>().Weapons.Count==1){
                i=0;
                text.text="No Weapon";
               GameObject CloneMen=Instantiate(Solder,new Vector3(j,SpawnSolder.transform.position.y,SpawnSolder.transform.position.z),Quaternion.Euler(new Vector3(0, 180, 0)));
               GameObject Weapon=Instantiate(WeaponRack.GetComponent<TradeWeapon>().Weapons[i],new Vector3(j,0,0),Quaternion.identity);
               Debug.Log(CloneMen.transform.GetChild(1).name);
               Transform WeaponMen=CloneMen.transform.GetChild(1);
               Weapon.transform.SetParent(WeaponMen);
               Weapon.transform.localPosition=new Vector3(0,0,0);
               Destroy(WeaponRack.GetComponent<TradeWeapon>().Weapons[i]);
               

               WeaponRack.GetComponent<TradeWeapon>().Weapons.RemoveAt(i);  
               Debug.Log(TradeW.GetComponent<TradeWeapon>().PosStand);    
               TradeW.GetComponent<TradeWeapon>().PosStand+=0.5f;
               Debug.Log(TradeW.GetComponent<TradeWeapon>().PosStand+"Deleted");           
              
        }else if(i==0){
              text.text=WeaponRack.GetComponent<TradeWeapon>().Weapons[i+1].name;
               GameObject CloneMen=Instantiate(Solder,new Vector3(j,SpawnSolder.transform.position.y,SpawnSolder.transform.position.z),Quaternion.Euler(new Vector3(0, 180, 0)));
               GameObject Weapon=Instantiate(WeaponRack.GetComponent<TradeWeapon>().Weapons[i],new Vector3(j,0,0),Quaternion.identity);
               Debug.Log(CloneMen.transform.GetChild(1).name);
               Transform WeaponMen=CloneMen.transform.GetChild(1);
               Weapon.transform.SetParent(WeaponMen);
               Weapon.transform.localPosition=new Vector3(0,0,0);
               Destroy(WeaponRack.GetComponent<TradeWeapon>().Weapons[i]);
               WeaponRack.GetComponent<TradeWeapon>().Weapons.RemoveAt(i);      
               TradeW.GetComponent<TradeWeapon>().PosStand+=0.5f;         
               Debug.Log(TradeW.GetComponent<TradeWeapon>().PosStand); 
               i++;
               
       }else{
            
               text.text=WeaponRack.GetComponent<TradeWeapon>().Weapons[i-1].name;
               GameObject CloneMen=Instantiate(Solder,new Vector3(j,SpawnSolder.transform.position.y,SpawnSolder.transform.position.z),Quaternion.Euler(new Vector3(0, 180, 0)));
               GameObject Weapon=Instantiate(WeaponRack.GetComponent<TradeWeapon>().Weapons[i],new Vector3(j,0,0),Quaternion.identity);
               Debug.Log(CloneMen.transform.GetChild(1).name);
               Transform WeaponMen=CloneMen.transform.GetChild(1);
               Weapon.transform.SetParent(WeaponMen);
               Weapon.transform.localPosition=new Vector3(0,0,0);
               Destroy(WeaponRack.GetComponent<TradeWeapon>().Weapons[i]);
               WeaponRack.GetComponent<TradeWeapon>().Weapons.RemoveAt(i);    
               TradeW.GetComponent<TradeWeapon>().PosStand+=0.5f;           
               Debug.Log(TradeW.GetComponent<TradeWeapon>().PosStand);
               i--;
               
       }
          } 
             
        
        
       
       
       
       
    }
    public void Next(){
          if(i<WeaponRack.GetComponent<TradeWeapon>().Weapons.Count-1){
            i++;
            Debug.Log(i);
            
            text.text=WeaponRack.GetComponent<TradeWeapon>().Weapons[i].name;
          }
        
    }
    public void Back(){
        if(i>0){
            i--;
            Debug.Log(i);
            
            text.text=WeaponRack.GetComponent<TradeWeapon>().Weapons[i].name;
        }
        
    }
}
