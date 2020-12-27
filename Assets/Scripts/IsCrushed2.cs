using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsCrushed2 : MonoBehaviour
{
    
    public GameObject objection;
    
    
    void Start()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other){

        if(other.tag == "box" || other.tag == "ground"){
        
        IsCrushed scription = objection.GetComponent<IsCrushed>();
        scription.iscrushed = 1;  
           
        }
        
    }

     void OnTriggerExit2D(Collider2D other){
 
        IsCrushed scription = objection.GetComponent<IsCrushed>();
        scription.iscrushed = 0;
     }
    

}
