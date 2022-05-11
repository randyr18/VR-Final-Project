using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
public class MainMenu : MonoBehaviour
{
void Start() {
    Cursor.lockState = CursorLockMode.None;
    Cursor.visible = true;
}
public void QuitGame() {  
        Debug.Log("QUIT Logged (only works in compiled game executable)");  
        Application.Quit();     // only works in complied game Exectuable
    }  
}
