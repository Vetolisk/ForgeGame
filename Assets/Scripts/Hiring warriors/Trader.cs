using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trader : MonoBehaviour, IInteractable
{
    public GameObject Panel;
    public bool isOn;
    private void Start()
    {
        Panel.SetActive(isOn);
    }
    public void Interact()
    {
        isOn=!isOn;
        if (isOn)
        {
            Debug.Log("Open");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Panel.SetActive(isOn);
        }
        else 
        {
            Debug.Log("Close");
            Cursor.lockState = CursorLockMode.Locked;
            Panel.SetActive(isOn);
        }
        
        
    }
}
