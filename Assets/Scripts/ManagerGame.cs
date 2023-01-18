
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
    private bool flag=true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (flag) {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                CameraOne.SetActive(false);
                CameraTwo.SetActive(true);
                flag = false;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = false;
                CameraOne.SetActive(true);
                CameraTwo.SetActive(false);
                flag = true;
            }
        }
        if (Input.GetMouseButton(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {

           
                if (hit.collider.CompareTag("Solder"))
                {
                if (TargetSphereClone==null) {
                    Solder =  hit.collider.gameObject.transform.parent.gameObject;
                    TargetSphereClone = Instantiate(TargetSphere, hit.collider.gameObject.transform.position, Quaternion.identity) as GameObject;

                }
                    // hit.collider.gameObject.transform


                }
               
            
            
        }
       
        if (Input.GetMouseButton(1))
        {
            if (TargetSphere!=null&& Solder!=null) {
                Destroy(TargetSphereClone);
            }
        }
    }
}
