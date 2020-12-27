using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoredisplay : MonoBehaviour
{
    
    public TextMeshProUGUI textbox;
 
    void Update(){
        
       
        textbox.text = "Your Score: " + scorecounter.score.ToString() + "m";
        


    }

    
        
}
