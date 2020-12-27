using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsCrushed : MonoBehaviour
{

    public GameObject character;
    public float iscrushed = 0;
    public float iscrushed2 = 0;
    public GameObject objection;
    
    
    
    void OnTriggerEnter2D(Collider2D other){
       
        if(other.tag == "box" || other.tag == "ground"){
         
         iscrushed2 = 1;
         
        }
        
        
    } 

     void OnTriggerExit2D(Collider2D other)
     {
        
         
         iscrushed2 = 0;
         
         
     }


    void Update(){

        if(iscrushed == 1 && iscrushed2 == 1){
            Destroy(character);
            scorecounter scription = objection.GetComponent<scorecounter>();
            scription.isded = 1;  
        }

    }
    
}
