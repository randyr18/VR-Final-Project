using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
public class LevelSelect: MonoBehaviour {  
    public void Level1Press() {  
        SceneManager.LoadScene("Level1");  
    }
    public void Level2Press() {  
        SceneManager.LoadScene("NightScene");  
    }
    public void Level3Press() {  
        SceneManager.LoadScene("ThirdScene");  
    }
} 
