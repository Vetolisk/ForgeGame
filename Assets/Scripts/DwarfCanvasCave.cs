using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DwarfCanvasCave : MonoBehaviour
{
    public void StartCave(){
        Cursor.visible=false;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene("Cave");
    }
}