using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawn2 : MonoBehaviour
{
    
        void OnTriggerEnter2D(Collider2D other){

        if(other.tag == "despawn"){
         
       

            Destroy(gameObject);

        
         
        
        }
    } 
}
