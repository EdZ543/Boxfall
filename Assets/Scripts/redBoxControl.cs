using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redBoxControl : MonoBehaviour
{
    
    public GameObject player;
    public GameObject objection;
    
    

    void OnTriggerEnter2D(Collider2D other){
       
        if(other.tag == "Player"){
         
        
        Destroy(player);
        scorecounter scription = objection.GetComponent<scorecounter>();
        scription.isded = 1; 
        
        
        }
    } 
}
