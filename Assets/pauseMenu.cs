using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    
    public static bool isPaused = false;
    public GameObject pauseMenuUI;

    
        public void stop ()
        {
        
            if(isPaused){
                resume();
            } else {
                pause();
            }
        

        }

        public void resume(){
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            isPaused = false;

        }

        void pause(){
             pauseMenuUI.SetActive(true);
             Time.timeScale = 0f;
             isPaused = true;
        }
    
}
