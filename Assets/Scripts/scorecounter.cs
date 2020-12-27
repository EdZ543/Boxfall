using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class scorecounter : MonoBehaviour
{
    
    public int timer = 0;
    public static int score = 0;
    public int isded = 0;
    public int timer2 = 0;
    public TextMeshProUGUI textbox;
 
    void Update(){
        
        textbox.text = "Score: " + score.ToString() + "m";
        if(isded == 0 && pauseMenu.isPaused == false){
        timer += 1;
        if(timer > 10){
            timer = 0;
            score ++;
        }
        }

        if(isded == 1){
            timer2++;
            if(timer2 == 1){
            SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
            }
        }


    }

    
        
}
