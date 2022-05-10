using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
public class MainMenu : MonoBehaviour
{
public void QuitGame() {  
        Debug.Log("QUIT Logged (only works in compiled game executable)");  
        Application.Quit();     // only works in complied game Exectuable
    }  
}
