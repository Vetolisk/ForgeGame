
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGame : MonoBehaviour
{
    public RaycastHit hit;
    public GameObject TargetSphere;
    public GameObject Solder;
    public GameObject TargetSphereClone;
    public GameObject CameraOne;
    public GameObject CameraTwo;

    public GameObject PanelMap;

    public GameObject CreateSlot;

     public GameObject Panel;
    public LayerMask layerMask;
    private bool flag=true;
    void Start(){
         PanelMap.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) {
            if (flag) {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                CameraOne.SetActive(false);
                CameraTwo.SetActive(true);
                PanelMap.SetActive(true);
                flag = false;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = false;
                CameraOne.SetActive(true);
                CameraTwo.SetActive(false);
                PanelMap.SetActive(false);
                flag = true;
            }
            Destroy(TargetSphereClone);
        }
        
       /* if (Input.GetMouseButton(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {

           
                if (hit.collider.CompareTag("Solder"))
                {
                if (TargetSphereClone==null) {
                    Solder =  hit.collider.gameObject.transform.parent.gameObject;
                    TargetSphereClone = Instantiate(TargetSphere,new Vector3( hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y-1, hit.collider.gameObject.transform.position.z), Quaternion.identity) as GameObject;

                   // Solder.GetComponent<AISolder>().agent.SetDestination(TargetSphereClone.transform.position);
                }
                    // hit.collider.gameObject.transform


                }
               
            
            
        }
        if(Input.GetMouseButton(0)&& TargetSphereClone != null)
        {
            Ray ray = CameraTwo.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, layerMask))
            {
                TargetSphereClone.transform.position = raycastHit.point;
                Solder.GetComponent<AISolder>().agent.SetDestination(TargetSphereClone.transform.position);
            }
           // Solder.GetComponent<AISolder>().agent.SetDestination(TargetSphereClone.transform.position);
        }
        if (Input.GetMouseButton(1))
        {
            if (TargetSphere!=null&& Solder!=null) {
                Destroy(TargetSphereClone);
            }
        }
        //if (TargetSphereClone != null)
        //{
        //    Ray ray = CameraTwo.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        //    if (Physics.Raycast(ray,out RaycastHit raycastHit,float.MaxValue,layerMask))
        //    {
        //        TargetSphereClone.transform.position = raycastHit.point;
        //        Solder.GetComponent<AISolder>().agent.SetDestination(TargetSphereClone.transform.position);
        //    }
        //}
        */
    }
    public void ButtonOnCreate(){
        if(CreateSlot.GetComponent<ManagerCreateSolder>().WeaponRack.GetComponent<TradeWeapon>().Weapons.Count>0){
           CreateSlot.GetComponent<ManagerCreateSolder>().text.text=  CreateSlot.GetComponent<ManagerCreateSolder>().WeaponRack.GetComponent<TradeWeapon>().Weapons[0].name;
           CreateSlot.GetComponent<ManagerCreateSolder>().i=0;
        }
             Panel.SetActive(true);
        

    }
    public void ButtonOfCreate(){
        Panel.SetActive(false);
    }
}
