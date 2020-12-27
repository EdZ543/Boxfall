using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToGame : MonoBehaviour
{
    
    
    public void GoToGame()
    {
        
        SceneManager.LoadScene("Game");
        scorecounter.score = 0;


    }
}
