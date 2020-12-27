using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class bombcounter : MonoBehaviour
{
    
    public int bombs = 0;
    public TextMeshProUGUI textbox;
    
 
    void Start(){
         
        //textbox = gameObject.GetComponent<TextMeshProUGUI>();

    }
 
    void Update(){
        
        textbox.text = "Bombs: " + bombs.ToString();


    }

    
        
}
