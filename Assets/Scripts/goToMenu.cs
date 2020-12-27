using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToMenu : MonoBehaviour
{
    
    
    public void GoToMenu ()
    {
        
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        

    }
}
